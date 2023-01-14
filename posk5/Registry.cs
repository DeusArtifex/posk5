using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posk5
{
    internal class Registry
    {
        public string name { get; }
        byte high;
        byte low;
        byte[] whole;
        public Registry(string name)
        {
            this.name = name;
            this.high = 0;
            this.low = 0;
            this.whole = new byte[] { high, low};
        }

        public byte GetValue(char hl)
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

        public void SetValue(char hl, byte value)
        {
            if (hl == 'H')
            {
                high = value;
            }
            else
            {
                low = value;
            }
            whole = new byte[] { high, low };
        }

        public void ClearValue(char hl)
        {
            ExecuteOperation(hl, GetValue(hl), 'S');
        }

        public void ExecuteOperation(char hl, byte value, char operation)
        {
            if(operation == 'A')
            {
                SetValue(hl, Convert.ToByte(GetValue(hl) + value));
            }
            else
            {
                SetValue(hl, Convert.ToByte(GetValue(hl) - value));
            }
        }
    }
    internal class CommandQueue
    {
        private Queue<Command> commandQueue;

        CommandQueue()
        {
            commandQueue = new Queue<Command>(8);
        }
         public void AddCommand(Command command)
        {
            commandQueue.Enqueue(command);
        }
        public void ExecuteCommand(Registry[] regs)
        {
            Command command = commandQueue.Dequeue();
            var decodedValues = DecodeParts(command.GetCommandValues());
            byte p2 = 0;
            switch (decodedValues.Item3)
            {
                case 'A':
                    if (decodedValues.Item1.Type == typeof(char[]))
                    {
                        if (decodedValues.Item2.Type == typeof(char[]))
                        {
                            foreach(Registry reg in regs)
                            {
                                if (reg.name.StartsWith(decodedValues.Item2[0])){
                                    p2 = reg.GetValue(decodedValues.Item2[1]);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            p2 = Command.ConvertBinary(decodedValues.Item2);
                        }
                        foreach (Registry reg in regs)
                        {
                            if (reg.name.StartsWith(decodedValues.Item1[0]))
                            {
                                reg.ExecuteOperation(decodedValues.Item1[1], p2, decodedValues.Item3);
                            }
                        }
                    }
                    else
                    {
                        return; //błąd
                    }
                    break;
                case 'S':
                    if (decodedValues.Item1.Type == typeof(char[]))
                    {
                        if (decodedValues.Item2.Type == typeof(char[]))
                        {
                            foreach (Registry reg in regs)
                            {
                                if (reg.name.StartsWith(decodedValues.Item2[0]))
                                {
                                    p2 = reg.GetValue(decodedValues.Item2[1]);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            p2 = Command.ConvertBinary(decodedValues.Item2);
                        }
                        foreach (Registry reg in regs)
                        {
                            if (reg.name.StartsWith(decodedValues.Item1[0]))
                            {
                                if(reg.GetValue(decodedValues.Item1[1]) < p2) { return; }               //Wynik mniejszy niż 0
                                reg.ExecuteOperation(decodedValues.Item1[1], p2, decodedValues.Item3);
                            }
                        }
                    }
                    else
                    {
                        return; //błąd
                    }
                    break;
                case 'M':
                    if (decodedValues.Item1.Type == typeof(char[]))
                    {
                        if (decodedValues.Item2.Type == typeof(char[]))
                        {
                            foreach (Registry reg in regs)
                            {
                                if (reg.name.StartsWith(decodedValues.Item1[0]))
                                {
                                    p2 = reg.GetValue(decodedValues.Item1[1]);
                                    reg.ClearValue(decodedValues.Item1[1]);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            return; //błąd
                        }
                        foreach (Registry reg in regs)
                        {
                            if (reg.name.StartsWith(decodedValues.Item2[0]))
                            {
                                reg.ExecuteOperation(decodedValues.Item2[1], p2, 'A');
                            }
                        }
                    }
                    else
                    {
                        return; //błąd
                    }
                    break;
            }
            

        }
        private dynamic DecodeParts(Tuple<string, string, char> t)
        {
            if (t.Item1.Length == 2 && t.Item1.Length == 2)
            {
                return (t.Item1.ToCharArray(), t.Item2.ToCharArray(), t.Item3);
            } 
            else if (t.Item1.Length != 2 && t.Item1.Length == 2) 
            {
                return (t.Item1, t.Item2.ToCharArray(), t.Item3);
            }
            else
            {
                return (t.Item1.ToCharArray(), t.Item2, t.Item3);
            }
        }
    }
}
