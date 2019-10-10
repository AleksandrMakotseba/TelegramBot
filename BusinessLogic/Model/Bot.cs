using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace BusinessLogic.Model
{
    public class Bot
    {
        private BotSettings BotSettings { get; set; }
        public TelegramBotClient TelegramBotClient { get; private set; }
        public TelegramBotClient GetTelegramBotClient()
        {
            if (TelegramBotClient != null)
            {
                return TelegramBotClient;
            }
            else
            {
                TelegramBotClient= new TelegramBotClient(BotSettings.HTTP_API);
            }
            return TelegramBotClient;
        }
    }
}