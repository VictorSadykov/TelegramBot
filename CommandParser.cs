using HW11.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal class CommandParser
    {
        private List<IChatCommand> commands = new List<IChatCommand>();

        public List<Word> dictionary;

        public bool IsTextCommand(string message)
        {
            var command = commands.Find(x => x.CheckMessage(message));
            return command is IChatTextCommand;
        }
    }
}
