using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal class Messenger
    {

        public string CreateTextMessage(Conversation chat)
        {
            string lastMessage = chat.GetLastMessage();
            string outputText;

            switch (lastMessage)
            {
                case "/saymehi":
                    outputText = "Hello " + chat.GetFirstName();
                    break;
                default:
                    char delimiter = ',';
                    outputText = string.Join(delimiter, chat.GetTextMessages());
                    break;
            }

            return outputText;
        }
    }
}
