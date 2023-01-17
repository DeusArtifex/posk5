using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posk5
{
    internal class Command
    {
        private string part1;
        private string part2;
        private char operation;
        public Command(string part1)
        {
            this.part1 = part1;
        }
        public Command(string part1, string operation, string part2)
        {
            this.part1 = part1;
            this.part2 = part2;
            this.operation = operation[0];
        }

        private string OperationSymbol()
        {
            switch (operation)
            {
                case 'A': return "ADD";
                case 'S': return "SUB";
                case 'M': return "MOV";
                default: return "";
            }
        }

        public char Operation
        {
            set { operation = value; }
            get { return operation; }
        }
        public string Part1
        {
            set { part1 = value; }
            get { return part1; }

        }
        public string Part2
        {
            set 
            {
                if (char.IsLetter(value[0])) { part2 = value; }
                else { part2 = value.PadLeft(8, '0'); }
            }
            get { return part2; }
        }

        public override string ToString()
        {
            StringBuilder command = new StringBuilder(part1);
            command.Append(' ');
            command.Append(OperationSymbol());
            command.Append(' ');
            command.Append(part2);
            return command.ToString();
        }

        public static byte ConvertBinary(string binary)
        {
            byte output = Convert.ToByte(binary, 2);
            return output;
        }

    }

}
