using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posk5
{
    internal class Command
    {
        private string part1;           //W obiekcie komendy, części zawierają łańcuchy znaków zamiast reprezentacji bitowej, jako że na tych wartościach nie mają być prowadzone -
        private string part2;           // - operacje, a mają umożliwiać identyfikowanie odpowiednich operacji oraz reprezentowanie komend jako tekst.
        private char operation;
        public Command(string part1)    //Konstruktor z jednym parametrem, do rozpoczęcia budowy zadania. Wywoływany po zatwierdzeniu jedej części.
        {
            this.part1 = part1;
        }
        public Command(string part1, string operation, string part2)    //Przeciążenie konstruktora, przyjmuje 3 parametry, tworzy komendę w całości.
        {                                                               //Wywoływany przy wczytywaniu makra, tworzy całą komendę z gotowych części.
            this.part1 = part1;
            this.part2 = part2;
            this.operation = operation[0];
        }

        private string OperationSymbol()        //Dekodowanie całej nazwy operacji bazując na pierwszym znaku. Przydatne przy zczytywaniu tekstowej reprezentacji komendy.
        {
            switch (operation)
            {
                case 'A': return "ADD";
                case 'S': return "SUB";
                case 'M': return "MOV";
                default: return "";
            }
        }

        public char Operation                   //Właściwość operacji, przypisuje lub zwraca znak operacji. Wywolywane spoza obiektu komendy, aby nie edytować bezpośrednio.
        {
            set { operation = value; }
            get { return operation; }
        }
        public string Part1                     //Jak wyżej, ale dla pierwszej części równania
        {
            set { part1 = value; }
            get { return part1; }

        }
        public string Part2                     //Jak wyżej, ale dla drugiej części
        {
            set 
            {
                if (char.IsLetter(value[0])) { part2 = value; } //Dodatkowo, jeżeli przypisany jest rejestr, wartość przypisana jest bezpośrednio, jeżeli wartość liczbowa - 
                else { part2 = value.PadLeft(8, '0'); }         // - przypisywana jest wartość z wyrównaniem do 8 znaków w bajcie. Czysto kosmetyczne, aby komenda lepiej -
            }                                                   // - wyglądała w polu wyświetlającym kolejkę.
            get { return part2; }
        }

        public override string ToString()                       //Nadpisanie metody konwertującej obiekt na łąńcuch znaków. Do wywołania w miejscach gdzie potrzebna jest -
        {                                                       // - reprezentacja tekstowa komendy.
            StringBuilder command = new StringBuilder(part1);
            command.Append(' ');                                //Tworzony jest obiekt konstrukcyjny, do którego dodawane są kolejne części całej operacji, po czym - 
            command.Append(OperationSymbol());                  // - gotowy łańcuch jest zwracany na wyjście.
            command.Append(' ');
            command.Append(part2);
            return command.ToString();
        }

        public static byte ConvertBinary(string binary)         //Konwersja z łańcucha w formie binarnej na cały bajt.
        {
            byte output = Convert.ToByte(binary, 2);
            return output;
        }

    }

}
