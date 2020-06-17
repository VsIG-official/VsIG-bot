using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace VsigBot
{
	class VsigBot
	{
		static void Main()
		{
			var botClient = new TelegramBotClient("YOUR_ACCESS_TOKEN_HERE");
			var me = botClient.GetMeAsync().Result;
			Console.WriteLine(
			  $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
			);
		}
	}
}
