using Rocket.Chat.Api.Core.RestHelpers;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{
    public interface IChatService
    {
        void Delete();
        void FollowMessage();
        void GetDeletedMessages();
        void GetMentionedMessages();
        void GetMessage();
        void GetMessageReadReceipts();
        void GetPinnedMessages();
        void GetSnippetedMessageById();
        void GetStarredMessages();
        void GetThreadMessages();
        void GetThreadsList();
        void IgnoreUser();
        void PinMessage();
        void PostMessage();
        void React();
        void ReportMessage();
        void Search();
        void StarMessage();
        void SendMessage();
        void SyncThreadMessages();
        void SyncThreadsList();
        void UnfollowMessage();
        void UnPinMessage();
        void UnStarMessage();
        void Update();
    }

    internal class ChatService: IChatService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"chat.{endPoint}");

        private readonly IRestClientService _restClientService;

        public ChatService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public void Delete() => throw new NotImplementedException();
        public void FollowMessage() => throw new NotImplementedException();
        public void GetDeletedMessages() => throw new NotImplementedException();
        public void GetMentionedMessages() => throw new NotImplementedException();
        public void GetMessage() => throw new NotImplementedException();
        public void GetMessageReadReceipts() => throw new NotImplementedException();
        public void GetPinnedMessages() => throw new NotImplementedException();
        public void GetSnippetedMessageById() => throw new NotImplementedException();
        public void GetStarredMessages() => throw new NotImplementedException();
        public void GetThreadMessages() => throw new NotImplementedException();
        public void GetThreadsList() => throw new NotImplementedException();
        public void IgnoreUser() => throw new NotImplementedException();
        public void PinMessage() => throw new NotImplementedException();
        public void PostMessage() => throw new NotImplementedException();
        public void React() => throw new NotImplementedException();
        public void ReportMessage() => throw new NotImplementedException();
        public void Search() => throw new NotImplementedException();
        public void StarMessage() => throw new NotImplementedException();
        public void SendMessage() => throw new NotImplementedException();
        public void SyncThreadMessages() => throw new NotImplementedException();
        public void SyncThreadsList() => throw new NotImplementedException();
        public void UnfollowMessage() => throw new NotImplementedException();
        public void UnPinMessage() => throw new NotImplementedException();
        public void UnStarMessage() => throw new NotImplementedException();
        public void Update() => throw new NotImplementedException();
    }
}