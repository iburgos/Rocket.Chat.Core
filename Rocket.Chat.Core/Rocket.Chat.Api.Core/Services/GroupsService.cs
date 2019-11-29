using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Domain;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IGroupsService
    {
        void AddAll();
        void AddLeader();
        void AddModerator();
        void AddOwner();
        void Archive();
        void Close();
        void Counters();
        void Create();
        void Delete();
        void Files();
        void GetIntegrations();
        void History();
        void Info();
        void Invite();
        void Kick();
        void Leave();
        Task <Result<Groups>> List();
        void ListAll();
        void Moderators();
        void Members();
        Task <Result<Messages>> Messages(string roomId);
        void Open();
        void RemoveLeader();
        void RemoveModerator();
        void RemoveOwner();
        void Rename();
        void Roles();
        void SetAnnouncement();
        void SetCustomFields();
        void SetDescription();
        void SetPurpose();
        void SetReadOnly();
        void SetTopic();
        void SetType();
        void Unarchive();
    }

    public class GroupsService : IGroupsService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"groups.{endPoint}");

        private readonly IRestClientService _restClientService;

        public GroupsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public void AddAll() => throw new NotImplementedException();
        public void AddLeader() => throw new NotImplementedException();
        public void AddModerator() => throw new NotImplementedException();
        public void AddOwner() => throw new NotImplementedException();
        public void Archive() => throw new NotImplementedException();
        public void Close() => throw new NotImplementedException();
        public void Counters() => throw new NotImplementedException();
        public void Create() => throw new NotImplementedException();
        public void Delete() => throw new NotImplementedException();
        public void Files() => throw new NotImplementedException();
        public void GetIntegrations() => throw new NotImplementedException();
        public void History() => throw new NotImplementedException();
        public void Info() => throw new NotImplementedException();
        public void Invite() => throw new NotImplementedException();
        public void Kick() => throw new NotImplementedException();
        public void Leave() => throw new NotImplementedException();

        public async Task<Result<Groups>> List()
        {
            var response = await _restClientService.Get<Groups>(GetUrl("list"));

            Result<Groups> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Groups>(response.Result);
            else
                loginResult = new Result<Groups>(response.Message);

            return loginResult;
        }

        public void ListAll() => throw new NotImplementedException();
        public void Moderators() => throw new NotImplementedException();
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

        public void Open() => throw new NotImplementedException();
        public void RemoveLeader() => throw new NotImplementedException();
        public void RemoveModerator() => throw new NotImplementedException();
        public void RemoveOwner() => throw new NotImplementedException();
        public void Rename() => throw new NotImplementedException();
        public void Roles() => throw new NotImplementedException();
        public void SetAnnouncement() => throw new NotImplementedException();
        public void SetCustomFields() => throw new NotImplementedException();
        public void SetDescription() => throw new NotImplementedException();
        public void SetPurpose() => throw new NotImplementedException();
        public void SetReadOnly() => throw new NotImplementedException();
        public void SetTopic() => throw new NotImplementedException();
        public void SetType() => throw new NotImplementedException();
        public void Unarchive() => throw new NotImplementedException();
    }
}