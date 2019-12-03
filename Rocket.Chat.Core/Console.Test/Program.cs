using Rocket.Chat.Api.Core;
using Rocket.Chat.Api.Core.Services;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;
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

                    if (channel.Fname == "testingChannel")
                    {
                        var result = await DeleteChannel(rocketChat, channel.Id);

                        //ChannelQuery.History query = new ChannelQuery.History
                        //{
                        //    RoomId = channel.Id,
                        //    Offset = 50,
                        //    Inclusive = true
                        //};

                        //Result<Messages> messagesResult = await rocketChat.Api.Channels.History(query);
                        //var messages = messagesResult.Content;

                        //Result<Messages> messagesResult = await rocketChat.Api.Channels.Messages(channel.Id);
                        //var messages = messagesResult.Content;
                    }
                }
            }
        }

        private static async Task CreateChannel(RocketChat rocketChat)
        {
            var payload = new Payload.Create { name = "testingChannel" };
            await rocketChat.Api.Channels.Create(payload);
        }

        private static async Task<Result<bool>> DeleteChannel(RocketChat rocketChat, string roomId)
        {
            return await rocketChat.Api.Channels.Delete(roomId);
        }
    }
}
