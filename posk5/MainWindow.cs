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
        private char[] curReg = new char[2];
        private Command currentCommand;
        private Registry[] regs;
        public MainWindow()
        {
            regs = new Registry[4]
            {
                new Registry("AX"),
                new Registry("BX"),
                new Registry("DX"),
                new Registry("CX")
            };
            InitializeComponent();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            if (currentCommand == null) { return; }
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

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            curReg[0] = ((Button)sender).Text.ToCharArray()[0];
        }

        private void btnHL_Click(object sender, EventArgs e)
        {
            curReg[1] = ((Button)sender).Text.ToCharArray()[0];
            byte value = regs[FindRegId(curReg[0])].GetValue(curReg[1]);//Wartość H/L w wybranym wcześniej rejestrze
            if (currentCommand == null)
            {
                currentCommand = new Command(curReg.ToString());
            }
            else
            {
                currentCommand.Part2 = curReg.ToString();
            }
        }

        private void btnFun_Click(object sender, EventArgs e)
        {

        }
        public int FindRegId(char regName)
        {
            foreach (var (reg, index) in regs.Select((value, i)=>(value,i)))
            {
                if (reg.name.StartsWith(regName.ToString())){
                    return index;
                }
            }
            return -1;
        }
    }
}
