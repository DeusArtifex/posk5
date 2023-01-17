using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public MainWindow()
        {
            regs = new Dictionary<char, Registry>
            {
                {'A', new Registry()},
                {'B', new Registry()},
                {'C', new Registry()},
                {'D', new Registry()}
            };
            queue = new CommandQueue();
            history = new HistoryQueue();
            shortcuts = new Command[8];

            InitializeComponent();
            StartState();
        }

        private void StartState()
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

        private void btnCommand_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "ADD":
                    currentCommand.Operation = 'A';
                    break;
                case "MOV":
                    currentCommand.Operation = 'M';
                    break;
                case "SUB":
                    currentCommand.Operation = 'S';
                    break;
            }
            resulltBox.Text += $" {((Button)sender).Text} ";
            DisableCommands();
            DisableQueues(false);
            InputReadonly(false);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            inputBox.Text = ((Button)sender).Text;
            DisableQueues();
            DisableHL(false);
            InputReadonly(true);
        }

        private void btnHL_Click(object sender, EventArgs e)
        {
            inputBox.Text = inputBox.Text + ((Button)sender).Text;
            DisableHL();
            DisableConfirm(false);
        }

        private void btnFun_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == "Clr")
            {
                StartState();
                if(currentCommand != null)
                {
                    currentCommand = null;
                }
            }
            else if(((Button)sender).Text == "GO" && btnGo.BackColor == Color.LimeGreen)
            {
                history_Update(queue.ExecuteCommand(regs));
                currentQueue_Update();
                valuesRegs_Update();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DisableConfirm();
            if (currentCommand == null)
            {
                currentCommand = new Command(inputBox.Text);
                DisableCommands(false);
            }
            else
            {
                currentCommand.Part2 = inputBox.Text;
                DisableEnqueue(false);
            }
            resulltBox.Text += inputBox.Text;
            inputBox.Clear();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            queue.AddCommand(currentCommand);
            currentCommand = null;
            currentQueue_Update();
            resulltBox.Clear();
        }

        private void DisableHL(bool b = true)
        {
            if (b) { btnH.Enabled = false; btnL.Enabled = false; }
            else { btnH.Enabled = true; btnL.Enabled = true; }
        }
        private void DisableCommands(bool b = true)
        {
            groupCommands.Enabled = !b;
        }
        private void DisableConfirm(bool b = true)
        {
            btnConfirm.Enabled = !b;
        }
        private void DisableQueues(bool b = true)
        {
            btnA.Enabled = !b;
            btnB.Enabled = !b;
            btnC.Enabled = !b;
            btnD.Enabled = !b;

        }
        private void DisableEnqueue(bool b = true)
        {
            btnEnqueue.Enabled = !b;
        }
        private void InputReadonly(bool b)
        {
            inputBox.ReadOnly = b;
        }
        private void currentQueue_Update()
        {
            currentQueue.Clear();
            if (queue.IsEmpty())
            {
                btnGo.BackColor = Color.Coral;
                return;
            }
            foreach(Command command in queue.ListCommands())
            {
                currentQueue.AppendText(command.ToString() + "\n");
            }
            btnGo.BackColor = Color.LimeGreen;
        }
        private void valuesRegs_Update()
        {
            valuesRegs.Clear();
            foreach(var reg in regs.Values)
            {
                valuesRegs.Text += reg.Value + "\n";
            }
        }
        private void history_Update(Command cmd)
        {
            history.AddCommand(cmd);
            historyBox.Items.Clear();
            foreach(var command in history.ListCommands())
            {
                historyBox.Items.Add(command.ToString());
            }
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.Equals(e.KeyChar, '0') && !char.Equals(e.KeyChar, '1') && !char.Equals(e.KeyChar, '\b'))
            {
                e.Handled = true;
            }
            DisableQueues(inputBox.Text.Length > 0);

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            if(inputBox.Text.Length > 0)
            {
                if (char.IsDigit(inputBox.Text[0]))
                {
                    DisableQueues();
                    DisableConfirm(false);
                }
            }
            else
            {
                if(currentCommand != null && char.IsLetter(currentCommand.Operation))
                {
                    DisableQueues(false);
                    DisableConfirm();
                }
            }
        }

        private void btnEnqueueAg_Click(object sender, EventArgs e)
        {
            string selItem = historyBox.Items[historyBox.SelectedIndex].ToString();
            if(selItem.Length <= 0) { return; }
            queue.AddCommand(history.GetCommandByText(selItem));
            currentQueue_Update();
        }

        private void btnQueueClr_Click(object sender, EventArgs e)
        {
            queue.ClearQueue();
            currentQueue_Update();
        }

        private void addShortcut_Click(object sender, EventArgs e)
        {
            shortcut = true;
        }

        private void btnSh_Click(object sender, EventArgs e)
        {
            int id = (int)char.GetNumericValue(((Button)sender).Text[1]) - 1;
            if (shortcut)
            {
                if(currentCommand != null && currentCommand.Part2 != null)
                {
                    shortcuts[id] = currentCommand;
                }
                shortcut = false;

            }
            else
            {
                if (shortcuts[id] != null)
                {
                    queue.AddCommand((Command)shortcuts[id]);
                    currentQueue_Update();
                }
            }
        }
    }
}
