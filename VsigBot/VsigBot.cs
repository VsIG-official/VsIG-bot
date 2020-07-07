using System;
using Telegram.Bot;
using dotenv.net.Utilities;

namespace VsigBot
{
	class VsigBot
	{
		static void Main()
		{
			//var envReader = new EnvReader();
			//var value = envReader.GetStringValue("TOKEN");
			var botClient = new TelegramBotClient("");
			var me = botClient.GetMeAsync().Result;
			Console.WriteLine(
			$"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");
			Console.ReadKey();
		}
	}
}
