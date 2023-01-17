using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posk5
{
    internal class Registry
    {
        private byte high;
        private byte low;
        public string Value
        {
            get
            {
                return Convert.ToString(high, 2).PadLeft(8, '0') + Convert.ToString(low, 2).PadLeft(8, '0');
            }
        }
        public Registry()
        {
            this.high = 0;
            this.low = 0;
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
    internal abstract class RegCmdQueue
    {
        private const int len = 8;
        private Queue<Command> commandQueue;
        public abstract Queue<Command> CommandsQueue { get; }
        public bool AddCommand(Command command)
        {
            if (CommandsQueue.Count == len) { return Overflow(); }
            CommandsQueue.Enqueue(command);
            return true;
        }
        public virtual bool Overflow()
        {
            return false;
        }
        public List<Command> ListCommands()
        {
            return CommandsQueue.ToList();
        }
        public bool IsEmpty()
        {
            return (CommandsQueue.Count == 0);
        }
    }
    internal class CommandQueue : RegCmdQueue
    {
        private const int len = 8;
        private Queue<Command> commandQueue;
        public override Queue<Command> CommandsQueue { get => commandQueue; }

        public CommandQueue()
        {
            commandQueue = new Queue<Command>(len);
        }
        public Command ExecuteCommand(Dictionary<char, Registry> regs)
        {
            Command command = commandQueue.Dequeue();
            byte value;
            char modified, hl, op;
            if (command.Operation == 'M')
            {
                if (command.Part2.Length != 2)
                {
                    return null; //błąd
                }
                value = regs[command.Part1[0]].GetValue(command.Part1[1]);
                modified = command.Part2[0];
                hl = command.Part2[1];
                op = 'A';
                regs[command.Part1[0]].ClearValue(command.Part1[1]);
            }
            else
            {
                if (command.Part2.Length != 2) { value = Command.ConvertBinary(command.Part2); }
                else { value = regs[command.Part2[0]].GetValue(command.Part2[1]); }
                modified = command.Part1[0];
                hl = command.Part1[1];
                op = command.Operation;
            }
            regs[modified].ExecuteOperation(hl, value, op);
            return command;
        }
        public void ClearQueue()
        {
            commandQueue.Clear();
        }
    }
    internal class HistoryQueue: RegCmdQueue
    {
        private const int len = 16;
        private Queue<Command> commandQueue;
        public override Queue<Command> CommandsQueue { get => commandQueue; }
        public override bool Overflow()
        {
            commandQueue.Dequeue();
            return true;
        }
        public HistoryQueue()
        {
            commandQueue = new Queue<Command>(16);
        }
        public Command GetCommandByText(string text)
        {
            foreach(Command command in commandQueue)
            {
                if(command.ToString() == text) { return command; }
            }
            return null;
        }
    }
}
