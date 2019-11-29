using Rocket.Chat.Api.Core;
using Rocket.Chat.Api.Core.Services;
using Rocket.Chat.Domain;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Console.Test
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () => await StartRestApi());
            System.Console.ReadLine();
        }


        private static async Task StartRestApi()
        {
            string host = "https://open.rocket.chat";
            RocketChat rocketChat = new RocketChat(host);

            var loginResult = await rocketChat.Api.Authentication.Login("", "");
            if (loginResult.Success)
            {
                var channels = await rocketChat.Api.Channels.ListJoined();

                foreach (var channel in channels.Content._Channels)
                {
                    System.Console.WriteLine($"{channel.Id} - {channel.Name}");

                    if (channel.Id == "B62Ymajnhem7r2rPW")
                    {
                        Result<Messages> messagesResult = await rocketChat.Api.Channels.Messages(channel.Id);
                        var messages = messagesResult.Content;
                    }
                }
            }
        }
    }
}
