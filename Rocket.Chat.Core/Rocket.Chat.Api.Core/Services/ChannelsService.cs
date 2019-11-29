using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Domain;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IChannelsService
    {
        void AddAll();
        void AddLeader();
        void Anonymousread();
        void Archive();
        void CleanHistory();
        void Close();
        void Counters();
        void Create();
        void Delete();
        void Files();
        void GetAllUserMentionsByChannel();
        void GetIntegrations();
        Task<Result<Messages>> History(string roomId);
        void Info();
        void Invite();
        void Join();
        void Kick();
        void Leave();
        Task<Result<Channels>> List();
        Task<Result<Channels>> ListJoined();
        void Members();
        Task<Result<Messages>> Messages(string roomId);
        void Moderators();
        void Online();
        void Open();
        void Removeleader();
        void Rename();
        void Roles();
        void SetCustomFields();
        void SetAnnouncement();
        void SetDefault();
        void SetDescription();
        void SetJoinCode();
        void SetPurpose();
        void SetReadOnly();
        void SetTopic();
        void SetType();
        void Unarchive();
    }

    public class ChannelsService: IChannelsService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"channels.{endPoint}");

        private readonly IRestClientService _restClientService;

        public ChannelsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public void AddAll() => throw new NotImplementedException();
        public void AddLeader() => throw new NotImplementedException();
        public void Anonymousread() => throw new NotImplementedException();
        public void Archive() => throw new NotImplementedException();
        public void CleanHistory() => throw new NotImplementedException();
        public void Close() => throw new NotImplementedException();
        public void Counters() => throw new NotImplementedException();
        public void Create() => throw new NotImplementedException();
        public void Delete() => throw new NotImplementedException();
        public void Files() => throw new NotImplementedException();
        public void GetAllUserMentionsByChannel() => throw new NotImplementedException();
        public void GetIntegrations() => throw new NotImplementedException();

        public async Task<Result<Messages>> History(string roomId)
        {
            string route = $"{GetUrl("history")}?roomId={roomId}";
            var response = await _restClientService.Get<Messages>(route);

            Result<Messages> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Messages>(response.Result);
            else
                loginResult = new Result<Messages>(response.Message);

            return loginResult;
        }

        public void Info() => throw new NotImplementedException();
        public void Invite() => throw new NotImplementedException();
        public void Join() => throw new NotImplementedException();
        public void Kick() => throw new NotImplementedException();
        public void Leave() => throw new NotImplementedException();

        public async Task<Result<Channels>> List()
        {
            var response = await _restClientService.Get<Channels>(GetUrl("list"));

            Result<Channels> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Channels>(response.Result);
            else
                loginResult = new Result<Channels>(response.Message);

            return loginResult;
        }

        public async Task<Result<Channels>> ListJoined()
        {
            var response = await _restClientService.Get<Channels>(GetUrl("list.joined"));

            Result<Channels> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Channels>(response.Result);
            else
                loginResult = new Result<Channels>(response.Message);

            return loginResult;
        }

        public void Members() => throw new NotImplementedException();

        public async Task<Result<Messages>> Messages(string roomId)
        {
            string route = $"{GetUrl("messages")}?roomId={roomId}";
            var response = await _restClientService.Get<Messages>(route);

            Result<Messages> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Messages>(response.Result);
            else
                loginResult = new Result<Messages>(response.Message);

            return loginResult;
        }

        public void Moderators() => throw new NotImplementedException();
        public void Online() => throw new NotImplementedException();
        public void Open() => throw new NotImplementedException();
        public void Removeleader() => throw new NotImplementedException();
        public void Rename() => throw new NotImplementedException();
        public void Roles() => throw new NotImplementedException(); 
        public void SetCustomFields() => throw new NotImplementedException();
        public void SetAnnouncement() => throw new NotImplementedException();
        public void SetDefault() => throw new NotImplementedException();
        public void SetDescription() => throw new NotImplementedException();
        public void SetJoinCode() => throw new NotImplementedException();
        public void SetPurpose() => throw new NotImplementedException();
        public void SetReadOnly() => throw new NotImplementedException();
        public void SetTopic() => throw new NotImplementedException();
        public void SetType() => throw new NotImplementedException();
        public void Unarchive() => throw new NotImplementedException();
    }
}