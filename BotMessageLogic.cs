using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace HW11
{
    internal class BotMessageLogic
    {
        private TelegramBotClient botClient;

        private Dictionary<long, Conversation> chatList;

        private Messenger messenger;

        public BotMessageLogic(TelegramBotClient botClient)
        {
            this.botClient = botClient;
            messenger = new Messenger();
            chatList = new Dictionary<long, Conversation>();
        }

        
        public async Task Response(MessageEventArgs e)
        {
            var id = e.Message.Chat.Id;

            if (!chatList.ContainsKey(id))
            {
                var newChat = new Conversation(e.Message.Chat);
                chatList.Add(id, newChat);
            }

            var chat = chatList[id];
            chat.AddMessage(e.Message);
            await SendTextMessage(chat);
        }

        private async Task SendTextMessage(Conversation chat)
        {
            var text = messenger.CreateTextMessage(chat);

            await botClient.SendTextMessageAsync(
                chatId: chat.GetId(),
                text: text);
        }
    }
}
