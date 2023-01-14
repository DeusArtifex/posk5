using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posk5
{
    internal class Command
    {
        public struct commandValues
        {
            public string part1 { get; }
            public string part2;
            public char operation;

            public commandValues(Command command)
            {
                this.part1 = command.part1;
                this.part2 = command.part2;
                this.operation = command.operation;
            }
        }

        private string part1;
        private string part2;
        private char operation;
        public Command(string part1)
        {
            this.part1 = part1;
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
            set { part2 = value; }
            get { return part2; }
        }

        public string GetCommand()
        {
            StringBuilder command = new StringBuilder(part1);
            command.Append(' ');
            command.Append(OperationSymbol());
            command.Append(' ');
            command.Append(part2);
            return command.ToString();
        }

        public dynamic GetCommandValues()
        {
            commandValues values = new commandValues();
            return (values.part1, values.part2, values.operation);

        }

        public static byte ConvertBinary(string binary)
        {
            byte output = Convert.ToByte(binary, 2);
            return output;
        }

    }

}
