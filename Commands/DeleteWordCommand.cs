using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Commands
{
    internal class DeleteWordCommand : ChatTextCommandOption
    {
        public string ClearMessageFromCommand(string message)
        {
            return message.Substring(CommandText.Length + 1).Trim();
        }
    }
}
