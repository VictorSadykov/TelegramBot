using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace HW11
{
    internal class BotWorker
    {
        static TelegramBotClient botClient;
        static BotMessageLogic logic;

        public void Initialize()
        {
            botClient = new TelegramBotClient(BotCredentials.botToken);
            logic = new BotMessageLogic(botClient);
        }

        public void Start()
        {
            botClient.OnMessage += BotClient_OnMessage;
            botClient.StartReceiving();
        }

        

        public void Stop()
        {
            botClient.StopReceiving();
        }

        private async void BotClient_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                await logic.Response(e);
            }
        }
    }
}
