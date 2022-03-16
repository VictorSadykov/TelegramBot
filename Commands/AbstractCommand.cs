﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Commands
{
    internal abstract class AbstractCommand : IChatCommand
    {
        public string commandText;
        bool IChatCommand.CheckMessage(string message)
        {
            return commandText == message;
        }
    }
}
