using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posk5
{
    internal class Registry
    {
        private byte high;      //W obiekcie rejestru, wartości high oraz low są już w formie bajtów, tutaj przechowywane są faktyczne wartości dla każdego rejestru i na nich -
        private byte low;       // - prowadzone są operacje.
        public string Value
        {
            get                 //Wartość jest właściwością obiektu, sama takiej nie posiada, ale zwraca łańcuch znaków będący połączonym bajtem high i low.
            {
                return Convert.ToString(high, 2).PadLeft(8, '0') + Convert.ToString(low, 2).PadLeft(8, '0');
            }
        }
        public Registry()       //Konstruktor rejestu, przypisuje każdemu nowemu rejestrowi domyślne wartości 0
        {
            this.high = 0;
            this.low = 0;
        }

        public byte GetValue(char hl)   //Metoda do zwracania wartości bajtu rejestru z części high lub low, w zależności od parametru.
        {
            if (hl == 'H')
            {
                return high;
            }
            else
            {
                return low;
            }
        }

        public void SetValue(char hl, byte value)   //Ustawianie wartości wybranego bajtu high lub low rejestru
        {
            if (hl == 'H')
            {
                high = value;
            }
            else
            {
                low = value;
            }
        }

        public void ClearValue(char hl)             //Czyszczenie wartości bajtu rejestru poprzez wywołanie oberacji odejmowania go od samego siebie.
        {
            ExecuteOperation(hl, GetValue(hl), 'S');
        }

        public void ExecuteOperation(char hl, byte value, char operation)   //Wykonywanie na podanym bajcie rejestru operacji z zadaną wartością.
        {                                                   //Pod uwagę brane są tylko dodawanie i odejmowanie, przecuwanie jest dodawaniem z usunięciem wartości jednego rejestru
            if(operation == 'A')    //Dla dodawania
            {
                try
                {
                    SetValue(hl, Convert.ToByte(GetValue(hl) + value)); //Operacje na bajtach zwracają wartości int, należy je więc przekonwertować na bajtowe.
                }
                catch(OverflowException e)      //Jeżeli wartość wychodzi ponad zakres bajtu, przypisywana jest tylko maksymalna możliwa wartość, reszta nie jest brana pod uwagę
                {
                    SetValue(hl, Byte.MaxValue);
                }
            }
            else                    //Dla odejmowania
            {
                if (GetValue(hl) < value) { ClearValue(hl); }           //Jeżeli odejmowanie miałoby wynik ujemny, wyrównywany jest do zera.
                SetValue(hl, Convert.ToByte(GetValue(hl) - value));
            }
        }
    }
    internal abstract class RegCmdQueue     //Obiekt kolejki komend rejestru, sam w sobie nie jest używany, ale dwa kolejne obiekty dziedziczą jego metody i właściwości.
    {
        public abstract int len { get; set; }
        public abstract Queue<Command> CommandsQueue { get; }   //Deklaracja metody, którą zadeklarować muszą wszystkie dziedziczące obiekty
        public bool AddCommand(Command command)                 //Deklaracja metody, z której korzystać będą wszystkie dziedziczące obiekty
        {
            if (CommandsQueue.Count == this.len && !Overflow()) { return Overflow(); }  //Jeżeli komenda nie zmieści się w kolejce, obiekt wywołuje swoją metodę overflow, w innych wypadkach ją doda.
            CommandsQueue.Enqueue(command);
            return true;
        }
        public virtual bool Overflow()      //Metoda overflow jest wirtualna, wykonuje zawarte tu operacje, chyba że obiekt nadpisze jej działanie swoim własnym.
        {
            return false;                   //Domyślnie obiekty kolejek komend rejestrów mają po prostu zwrócić fałsz i nic nie robić z komendą, jeżeli nie zmieści się w kolejce.
        }
        public List<Command> ListCommands()
        {
            return CommandsQueue.ToList();  //Metoda zwraca listę złożoną z komend znajdujących się w kolejce, co moim zdaniem ułatwia parsowanie.
        }
        public bool IsEmpty()               //Nazwa mówi za siebie, metoda zwraca czy kolejka jest pusta.
        {
            return (CommandsQueue.Count == 0);
        }
    }
    internal class CommandQueue : RegCmdQueue   //Kolejka komend, jest kolejką komend, które kolejne będą wykonywane na rejestrach. Wszystkie rejestry dzielą kolejkę.
    {
        public override int len { get; set; }
        private Queue<Command> commandQueue;
        public override Queue<Command> CommandsQueue { get => commandQueue; }   //Właściwość CommandsQueue ma zwracać kolejkę, którą posiada jako pole. Umożliwia operacje -
                                                                                // - poprzez metody dziedziczone.
        public CommandQueue()                           //Konstruktor. Tworzy kolejkę o długości zadanej przez stałą specyficzną dla rodzaju kolejki.
        {
            len = 8;
            commandQueue = new Queue<Command>(len);
        }
        public Command ExecuteCommand(Dictionary<char, Registry> regs)      //Funkcja wykonująca komendy(operacje) na rejestrach które zostają do niej podane.
        {
            Command command = commandQueue.Dequeue();       //Najpierw komenda usuwana jest z kolejki, a jej wartość przypisana do zmiennej.
            byte value;
            char modified, hl, op;                          //Tworzone są też tymczasowe zmienne dla odpowiednich wartości wyczytanych z komendy.
            if (command.Operation == 'M')
            {
                if (command.Part2.Length != 2)              //Dla operacji MOV - przesunięcia, obie części komendy muszą być rejestrami. Operacja więc nie wykona się,
                {                                           //Jeżeli  druga część nie jest rejestrem.
                    return null;
                }
                value = regs[command.Part1[0]].GetValue(command.Part1[1]);  //Jeżeli obie części są rejestrami (przy działaniu narzuconym przez program, pierwsza musi być) -
                modified = command.Part2[0];                                // - do wartości tymczasowych przypistwane są  wartości z drugiej części, a wartość dla dodawania -
                hl = command.Part2[1];                                      // - z pierwszej, po czym wartość w rejestrze z pierwszej wartości jest czyszczona.
                op = 'A';                                                   //Ma to na celu wywołanie w niejako odwrotnej kolejności normalnego dodawania - wartości pierwszego -
                regs[command.Part1[0]].ClearValue(command.Part1[1]);        // - do drugiego rejestru - przesuwa wartość z jednego do drugiego.
            }
            else
            {                                                               //Dla dodawania i odejmowania, nie ma potrzeby zamiany miejscami, wartości są więc po prostu -
                if (command.Part2.Length != 2) { value = Command.ConvertBinary(command.Part2); }    // - przypisywane do odpowiadających zmiennych.
                else { value = regs[command.Part2[0]].GetValue(command.Part2[1]); }
                modified = command.Part1[0];
                hl = command.Part1[1];
                op = command.Operation;
            }
            regs[modified].ExecuteOperation(hl, value, op);     //Wywoływana jest już na rejestrze metoda wykonania operacji, z wartościami wcześniej przypisanymi odpowiednio.
            return command;                                     //Na wyjście zwracana jest komenda wykonywana przez rejestr, aby mogła być przypisana do historii.
        }
        public void ClearQueue()    //Czyszczenie kolejki, mówi samo za siebie
        {
            commandQueue.Clear();
        }
    }
    internal class HistoryQueue: RegCmdQueue        //Obiekt historii kolejki.
    {
        public override int len { get; set; }
        private Queue<Command> commandQueue;
        public override Queue<Command> CommandsQueue { get => commandQueue; } //Nadpisanie jak w powyższym obiekcie
        public override bool Overflow()     //Funkcja overflow, tutaj nadpisana
        {
            commandQueue.Dequeue();         //Dla kolejki historii, jeżeli jest ona pełna, ma zostać usunięty pierwszy obiekt który został do niej dodany i zwrócona będzie prawda
            return true;
        }
        public HistoryQueue()               //Konstruktor kolejki historii z długością domyślną 16
        {
            len = 16;
            commandQueue = new Queue<Command>(len);
        }
        public Command GetCommandByText(string text)    //Metoda mająca zwrócić komendę, na podstawie jej reprezentacji tekstowej
        {
            foreach(Command command in commandQueue)    //Każda z komend w historii jest sprawdzana pod kątem jej reprezentacji tekstowej, gdy zgadza się z tą podaną do -
            {                                           // - metody, zwracany jest obiekt tej komendy. Kolejność nie ma tu znaczenia, gdyż obiekt nie jest usuwany z historii.
                if(command.ToString() == text) { return command; }
            }
            return null;
        }
    }
}
