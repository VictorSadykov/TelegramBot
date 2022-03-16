using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Commands
{
    internal abstract class ChatTextCommandOption : IChatCommand
    {
        public string CommandText;

        bool IChatCommand.CheckMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
