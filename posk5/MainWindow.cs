using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posk5
{
    public partial class MainWindow : Form
    {
        private Command currentCommand;
        private Dictionary<char, Registry> regs;
        private CommandQueue queue;
        private HistoryQueue history;
        private bool shortcut = false;
        private Command[] shortcuts;
        private Queue<Command> macroQueue;
        private bool macroRunning = false;
        public MainWindow()
        {
            regs = new Dictionary<char, Registry>   //Deklaracja słownika z rejestrami
            {
                {'A', new Registry()},              //Słownik pozwala tu na odnoszenie się do rejestrów, używając liter jako ich identyfikatorów
                {'B', new Registry()},
                {'C', new Registry()},
                {'D', new Registry()}
            };
            queue = new CommandQueue();             //Utworzenie obiektu kolejki komend
            history = new HistoryQueue();           //Utworzenie obiektu historii komend
            shortcuts = new Command[8];             //Utworzenie tablicy ze skrótami 

            InitializeComponent();
            openMacro.InitialDirectory = Application.StartupPath;
            StartState();                           //Wywołanie funkcji ustawiającej dostępność pól i przycisków do bazowego stanu
        }

        private void StartState()                   //Funkcja ta czyści pola do przechowywania komendy oraz jej części, a następnie odpowiednio zmienia dostępność elementów
        {
            inputBox.Clear();
            resulltBox.Clear();
            DisableQueues(false);
            DisableCommands();
            DisableHL();
            DisableEnqueue();
            DisableConfirm();
            InputReadonly(true);
        }

        private void DisableHL(bool b = true)       //Przełączenie stanu przycisków do uzupełnienia High/Low rejestru. High - bajt z llewej, Low - bajt z prawej
        {
            if (b) { btnH.Enabled = false; btnL.Enabled = false; }
            else { btnH.Enabled = true; btnL.Enabled = true; }
        }
        private void DisableCommands(bool b = true) //Przełączenie stanu przycisków operacji ADD, MOV, SUB
        {
            groupCommands.Enabled = !b;
        }
        private void DisableConfirm(bool b = true)  //Przełączenie stanu zatwierdzenia danej części operacji (przycisk przy polu wprowadzania)
        {
            btnConfirm.Enabled = !b;
        }
        private void DisableQueues(bool b = true)   //Przełączenie stanu przycisków odpowiedzialnych za wybór rejestru(kolejki)
        {
            btnA.Enabled = !b;
            btnB.Enabled = !b;
            btnC.Enabled = !b;
            btnD.Enabled = !b;

        }
        private void DisableEnqueue(bool b = true)  //Przełączanie stanu dodania całej komendy/operacji do kolejki
        {
            btnEnqueue.Enabled = !b;
        }
        private void InputReadonly(bool b)          //Przełączenie możliwości wpisywania przez użytkownika wartości z klawiatury
        {
            inputBox.ReadOnly = b;
        }

        //Update functions

        private void currentQueue_Update()          //Metoda aktualizacji kolejki wyświetlanej w polu tekstowym na ekranie. 
        {
            currentQueue.Clear();                               //Metoda czyści najpierw pole tekstowe, a następnie  sprawdza czy kolejka jest pusta.
            if (queue.IsEmpty())                                //Dla pustej kolejki od razu zmieniany jest kolor przycisku do wykonania kolejnego zadania, a metoda kończy się.
            {
                btnGo.BackColor = Color.Coral;
                return;
            }
            foreach(Command command in queue.ListCommands())    //Gdy kolejka nie jest pusta, listowane są komendy z kolejki i każda po kolei dopisywana jest do pola tekstowego.
            {
                currentQueue.AppendText(command.ToString() + Environment.NewLine);
            }
            btnGo.BackColor = Color.LimeGreen;                  //Na końcu zmieniany jest kolor przycisku na zielony. Rozróżnienie kolorystyczne w celu wyższej przejżystości.
        }
        private void valuesRegs_Update()                        //Metoda aktualizacji wartości rejestrów wyświetlanych na ekranie.
        {
            valuesRegs.Clear();                                 //Jak przy aktualizacji kolejki, najpierw zawartość jest czyszczona.
            foreach(var reg in regs.Values)                     //Potem dla każdego rejestru ze słownika pobierana jest wartość z wykorzystaniem odpowiedniej właściwości.
            {
                valuesRegs.Text += reg.Value + "\n";            //Na końcu wartość przypisywana jest do pola linia po linii
            }
        }
        private void history_Update(Command cmd)                //Metoda aktualizacji metody działa podobnie jak powyższe metody, ale jednocześnie przypisuje do historii -
        {                                                       // - ostatnią komendę, przekazaną w parametrze.
            history.AddCommand(cmd);
            historyBox.Items.Clear();
            foreach(var command in history.ListCommands())
            {
                historyBox.Items.Add(command.ToString());
            }
        }

        //Event handlers

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)  //Obsługa klawiszy klawiatury. Przy wciśnięciu sprawdza, czy klawisz jest dozwolony.
        {                                                                   //Pozwala to na ograniczenie do zer i jedynek oraz usunięcia znaku z pola.
            if(!char.Equals(e.KeyChar, '0') && !char.Equals(e.KeyChar, '1') && !char.Equals(e.KeyChar, '\b'))
            {
                e.Handled = true;
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)       //Metoda obsługująca zmiany w polu tekstowym wprowadzania części składowych komendy
        {
            if(inputBox.Text.Length > 0)                                    //Jeżeli w polu po aktualizacji coś się znajduje, sprawdzane jest, czy jest to liczba na miejscu 0.
            {                                                               //Taki stan oznacza, że wprowadzane są znaki z klawiatury, wyłączane jest więc wprowadzanie rejestru.
                if (char.IsDigit(inputBox.Text[0]))
                {
                    DisableQueues();
                    DisableConfirm(false);                                  //Udostępniany jest również przycisk zatwierdzenia, jako że wprowadzić można od 1 do 8 znaków.
                }
            }
            else                                                            //Jeżeli pole jest puste, a wprowadzany jest drugi element operacji, odblokowane są przyciski kolejek.
            {
                if(currentCommand != null && char.IsLetter(currentCommand.Operation))
                {
                    DisableQueues(false);
                    DisableConfirm();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)                //Obsługa timera, który uruchamia się w trybie pracy automatycznej
        {

            if(queue.IsEmpty())                               //Jeżeli kolejka nie jest pusta, wykonywane jest kolejne zadanie.
            {
                btnGo.PerformClick();
            }
            if (macroRunning)                                               //Gdy uruchomione zostało makro, tryb automatyczny ma wyłączyć się sam po oczyszczeniu kolejki.
            {                                                               //Użycie dodatkowej zmiennej prawda/fałsz, sprawia że automatyczne wyłączenie następuje tylko -
                if(queue.IsEmpty())                                         // - przy wywołaniu makra
                {
                    btnMode.PerformClick();                                 //Do przełączenia trybu gdy kolejka jest pusta użyty jest przycisk, co poprawia przejżystość.
                    macroRunning = false;
                }
                else
                {                                                           //Jeżeli kolejka nie jest pusta, sprawdzane jest, czy można dodać kolejne zadanie.
                    if (macroQueue.Count > 0 && queue.AddCommand(macroQueue.Peek())) { macroQueue.Dequeue(); }  //Element usuwany jest z kolejki tylko jeżeli zostanie dodany z powodzeniem
                }
            }
        }

        //Przyciski
        private void btnCommand_Click(object sender, EventArgs e)           //Przyciski operacji
        {
            switch (((Button)sender).Text)
            {
                case "ADD":                                                 //Dodawane są do obiektu komendy tylko pojedyncze znaki, są łatwiejsze do późniejszej pracy
                    currentCommand.Operation = 'A';
                    break;
                case "MOV":
                    currentCommand.Operation = 'M';
                    break;
                case "SUB":
                    currentCommand.Operation = 'S';
                    break;
            }
            resulltBox.Text += $" {((Button)sender).Text} ";                //Tekst w niezmienionej formie dopisywany jest do pola które wyświetla wynikową komendę.
            DisableCommands();
            DisableQueues(false);                                           //Przyciski operacji są wyłączane, włączane są przyciski rejestrów oraz otwiera się pole tekstowe.
            InputReadonly(false);
        }

        private void btnReg_Click(object sender, EventArgs e)               //Obsługa przycisków rejestrów. Wyłącza odpowiednie elementy, włącza kolejne do wprowadzenia.
        {
            inputBox.Text = ((Button)sender).Text;                          //Wartość przypisana jest do pola tekstowego
            DisableQueues();
            DisableHL(false);
            InputReadonly(true);
        }

        private void btnHL_Click(object sender, EventArgs e)                //Obsługa przycisków odpowiadających za dodanie High/Low rejestru. Jak wyżej, zmienia aktywność -
        {                                                                   // - elementów, a wartość przypisuje do pola
            inputBox.Text = inputBox.Text + ((Button)sender).Text;
            DisableHL();
            DisableConfirm(false);
        }

        private void btnFun_Click(object sender, EventArgs e)               //Obsługa przycisków funkcjijnych (czyszczenie wprowadzanego lub wykonanie kolejnego polecenia)
        {
            if (((Button)sender).Text == "Clr")
            {
                StartState();                                               //Po tekście określany jest wciśnięty przycisk, stan przycisków zmieniany jest na bazowy -
                if (currentCommand != null)                                 // - a pola wprowadzania komendy czyszczone.
                {
                    currentCommand = null;
                }
            }
            else if (((Button)sender).Text == "GO" && btnGo.BackColor == Color.LimeGreen)
            {
                history_Update(queue.ExecuteCommand(regs));                 //Możliwość wykonania kolejnej komendy określana jest na podstawie koloru przycisku, który -
                currentQueue_Update();                                      // - zmienia metoda aktualizująca. W przypisaniu komendy do historii wywołana jest metoda -
                valuesRegs_Update();                                        // - która ją najpierw wykonuje po czym zwraca na wyjście.
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)           //Obsługa przycisku zatwierdzenia wpisywania wartości/rejestru
        {
            DisableConfirm();                                               //Przycisk sam się wyłącza, po czym jeżeli nie istnieje obecna komenda, tworzy ją, a w przeciwnym -
            if (currentCommand == null)                                     // - wypadku dodaje do istniejącej kolejną jej część.
            {
                currentCommand = new Command(inputBox.Text);
                DisableCommands(false);
            }
            else
            {
                currentCommand.Part2 = inputBox.Text;                       //Przy dopisaniu kolejnej części, udostępniany jest przycisk dodania komendy do kolejki.
                DisableEnqueue(false);
            }
            resulltBox.Text += inputBox.Text;                               //Niezależnie od powyższego sprawdzenia, tekst z wprowadzania części, przypisany jest na koniec -
            inputBox.Clear();                                               // - pola komendy wynikowej, po czym pole części jest czyszczone.
        }

        private void btnEnqueue_Click(object sender, EventArgs e)           //Obsługa kolejkowania. Po wciśnięciu przycisku komenda jest dodawana do kolejki a obiekt komendy -
        {                                                                   // - dla głównego okna jest czyszczony, tak jak i pole wynikowe. Aktualizowana jest też kolejka.
            queue.AddCommand(currentCommand);
            currentCommand = null;
            currentQueue_Update();
            resulltBox.Clear();
        }

        private void btnEnqueueAg_Click(object sender, EventArgs e)         //Kolejkowanie ponownie komendy z historii. Pobierany jest obecnie wybrany element z listy -
        {                                                                   // - po czym przekazywany jest do obiektu historii, który zwraca odpowiednią komendę na wyjście.
            string selItem = historyBox.Items[historyBox.SelectedIndex].ToString();
            if (selItem.Length <= 0) { return; }
            queue.AddCommand(history.GetCommandByText(selItem));
            currentQueue_Update();
        }

        private void btnQueueClr_Click(object sender, EventArgs e)
        {
            queue.ClearQueue();                                             //Czyszczenie kolejki mówi samo za siebie. Kolejka jest czyszczona, a potem jej widok aktualizowany.
            currentQueue_Update();
        }

        private void addShortcut_Click(object sender, EventArgs e)          //Zmiana trybu wprowadzania skrótu
        {
            shortcut = true;
        }

        private void btnSh_Click(object sender, EventArgs e)                //Przyciski skrótu. Jeżeli tryb wprowadzania skrótu jest aktywny, obecnie wprowadzona komenda -
        {                                                                   // - przekazywana jest do tablicy skrótów, pod id odpowiadającym przyciskowi.
            int id = (int)char.GetNumericValue(((Button)sender).Text[1]) - 1;
            if (shortcut)                                                   //Po dodaniu skrótu, zmienna trybu dodawania jest przełączana na fałsz, niezależnie od efektu.
            {
                if (currentCommand != null && currentCommand.Part2 != null)
                {
                    shortcuts[id] = currentCommand;
                }
                shortcut = false;

            }
            else                                                             //Gdy po prostu wybierany był skrót, komenda z tablicy jest dodawana do kolejki, a kolejka aktualizowana.
            {
                if (shortcuts[id] != null)
                {
                    queue.AddCommand((Command)shortcuts[id]);
                    currentQueue_Update();
                }
            }
        }

        private void btnMode_Click(object sender, EventArgs e)              //Przełączenie trybu między krokowym a automatycznym. Przycisk przesuwa się na lewo/prawo -
        {                                                                   // - naśladując fizyczne przełączniki, a timer jest włączany lub wyłączany.
            if (btnMode.Dock == DockStyle.Left)
            {
                btnMode.Dock = DockStyle.Right;
                timer1.Enabled = true;
            }
            else
            {
                btnMode.Dock = DockStyle.Left;
                timer1.Enabled = false;
            }
        }

        private void btnMakro_Click(object sender, EventArgs e)             //Przycisk wyboru makra. Otwierane jest okienko, w którym przekazany ma zostać plik z komendami -
        {                                                                   // - makra. Komendy wyciągane są z pliku do kolejki, po czym pojedynczo przekazywane do właściwej -
            OpenFileDialog openMacro = new OpenFileDialog();                // - kolejki zadań, aż do jej zapełnienia.
            if(openMacro.ShowDialog() == DialogResult.OK && openMacro.FileName.ToLower().EndsWith(".txt"))
            {
                macroRunning = true;
                macroQueue = new Queue<Command>();
                foreach (string line in File.ReadLines(openMacro.FileName))
                {
                    string[] parts = line.Split(' ');
                    macroQueue.Enqueue(new Command(parts[0], parts[1], parts[2]));
                }
                while (queue.AddCommand(macroQueue.Peek()))
                {
                    macroQueue.Dequeue();
                }
                btnMode.PerformClick();                                     //Na końcu przełączany jest tryb na automatyczny, który wykonuje kolejne polecenia makra.
                currentQueue_Update();                                      //No i aktualizowana jest widoczna kolejka.
            }
        }
    }
}
