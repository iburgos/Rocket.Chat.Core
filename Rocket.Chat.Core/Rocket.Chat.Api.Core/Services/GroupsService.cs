using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services.Helpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Channels;
using Rocket.Chat.Domain.MethodResults.Groups;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{

    internal class GroupsService : IGroupsService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"groups.{endPoint}");

        private readonly IRestClientService _restClientService;

        public GroupsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<ChannelResult>> AddAll(Payload.AddAll payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("addAll"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> AddLeader(string roomId, string userId)
        {
            var payload = new Payload.UserAction { RoomId = roomId, UserId = userId };
            var response = await _restClientService.Post<CallResult>(GetUrl("addLeader"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> AddModerator(string roomId, string userId)
        {
            var payload = new Payload.UserAction { RoomId = roomId, UserId = userId };
            var response = await _restClientService.Post<CallResult>(GetUrl("addModerator"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> AddOwner(string roomId, string userId)
        {
            var payload = new Payload.UserAction { RoomId = roomId, UserId = userId };
            var response = await _restClientService.Post<CallResult>(GetUrl("addOwner"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> Archive(string roomId)
        {
            var payload = new Payload { RoomId = roomId };
            var response = await _restClientService.Post<CallResult>(GetUrl("archive"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> Close(string roomId)
        {
            var payload = new Payload { RoomId = roomId };
            var response = await _restClientService.Post<CallResult>(GetUrl("close"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<Counters>> Counters(GroupQuery.Counters query)
        {
            string route = $"{GetUrl("counters")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Counters>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> Create(Payload.Create payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("create"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Delete(string roomId)
        {
            var payload = new Payload { RoomId = roomId };
            var response = await _restClientService.Post<CallResult>(GetUrl("delete"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<Files>> Files(GroupQuery.Group query)
        {
            string route = $"{GetUrl("files")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Files>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Integrations>> GetIntegrations(string roomId)
        {
            var query = new GroupQuery.Group { RoomId = roomId };
            string route = $"{GetUrl("getIntegrations")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Integrations>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Messages>> History(GroupQuery.History query)
        {
            string route = $"{GetUrl("history")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> Info(string roomId)
        {
            var query = new GroupQuery.Group { RoomId = roomId };
            string route = $"{GetUrl("info")}{query.ToQueryString()}";
            var response = await _restClientService.Get<GroupResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> Invite(Payload.UserAction payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("invite"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> Kick(Payload.UserAction payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("kick"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> Leave(Payload payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("leave"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Groups>> List(BasicQuery query)
        {
            string route = $"{GetUrl("list")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Groups>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Groups>> ListAll(FullQuery query)
        {
            string route = $"{GetUrl("listAll")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Groups>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Moderators>> Moderators(GroupQuery.Group query)
        {
            string route = $"{GetUrl("moderators")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Moderators>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Members>> Members(GroupQuery.Members query)
        {
            string route = $"{GetUrl("members")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Members>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Messages>> Messages(string roomId)
        {
            string route = $"{GetUrl("messages")}?roomId={roomId}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Open(string roomId)
        {
            var payload = new Payload { RoomId = roomId };
            var response = await _restClientService.Post<CallResult>(GetUrl("open"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> Removeleader(Payload.UserAction payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("removeLeader"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> RemoveModerator(Payload.UserAction payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("removeModerator"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> RemoveOwner(Payload.UserAction payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("removeOwner"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<GroupResult>> Rename(Payload.Rename payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("rename"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<RolesResult>> Roles(GroupQuery.Group query)
        {
            string route = $"{GetUrl("roles")}{query.ToQueryString()}";
            var response = await _restClientService.Get<RolesResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<AnnouncementResult>> SetAnnouncement(Payload.SetAnnouncement payload)
        {
            var response = await _restClientService.Post<AnnouncementResult>(GetUrl("setAnnouncement"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> SetCustomFields(Payload.SetCustomFields payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("setCustomFields"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> SetDescription(Payload.SetDescription payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("setDescription"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> SetPurpose(Payload.SetPurpose payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("setPurpose"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> SetReadOnly(Payload.SetReadOnly payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("setReadOnly"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> SetTopic(Payload.SetTopic payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("setTopic"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<GroupResult>> SetType(Payload.SetType payload)
        {
            var response = await _restClientService.Post<GroupResult>(GetUrl("setType"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Unarchive(Payload payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("unarchive"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }
    }
}