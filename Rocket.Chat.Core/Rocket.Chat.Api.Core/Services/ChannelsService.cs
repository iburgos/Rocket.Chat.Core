using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services.Helpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Channels;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{
    internal class ChannelsService: IChannelsService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"channels.{endPoint}");

        private readonly IRestClientService _restClientService;

        public ChannelsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<Channel>> AddAll(Payload.AddAll payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("addAll"), payload);
            return ProcessChannelResponse(response);
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

        public async Task<Result<Messages>> AnonymousRead(FullQuery query)
        {
            string route = $"{GetUrl("anonymousread")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
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

        public async Task<Result<Counters>> Counters(ChannelQuery.Counters query)
        {
            string route = $"{GetUrl("counters")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Counters>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Channel>> Create(Payload.Create payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("create"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<bool>> Delete(string roomId)
        {
            var payload = new Payload { RoomId = roomId };
            var response = await _restClientService.Post<CallResult>(GetUrl("delete"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<Files>> Files(ChannelQuery.Channel query)
        {
            string route = $"{GetUrl("files")}{query.ToQueryString()}";
            return ServiceHelper.MapResponse(await _restClientService.Get<Files>(route));
        }

        public async Task<Result<Mentions>> GetAllUserMentionsByChannel(string roomId)
        {
            var query = new ChannelQuery.Channel { RoomId = roomId };
            string route = $"{GetUrl("getAllUserMentionsByChannel")}{query.ToQueryString()}";
            return ServiceHelper.MapResponse(await _restClientService.Get<Mentions>(route));
        }

        public async Task<Result<Integrations>> GetIntegrations(string roomId)
        {
            var query = new ChannelQuery.Channel { RoomId = roomId };
            string route = $"{GetUrl("getIntegrations")}{query.ToQueryString()}";
            return ServiceHelper.MapResponse(await _restClientService.Get<Integrations>(route));
        }

        public async Task<Result<Messages>> History(ChannelQuery.History query)
        {
            string route = $"{GetUrl("history")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Channel>> Info(string roomId)
        {
            var query = new ChannelQuery.Channel { RoomId = roomId };
            string route = $"{GetUrl("info")}{query.ToQueryString()}";
            var response = await _restClientService.Get<ChannelResult>(route);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> Invite(Payload.UserAction payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("invite"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> Join(Payload.Join payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("join"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> Kick(Payload.UserAction payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("kick"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> Leave(Payload payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("leave"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<IEnumerable<Channel>>> List()
        {
            var response = await _restClientService.Get<ChannelsResult>(GetUrl("list"));
            return ProcessChannelsResponse(response);
        }

        public async Task<Result<IEnumerable<Channel>>> ListJoined()
        {
            var response = await _restClientService.Get<ChannelsResult>(GetUrl("list.joined"));
            return ProcessChannelsResponse(response);
        }

        public async Task<Result<Members>> Members(ChannelQuery.Members query)
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

        public async Task<Result<Moderators>> Moderators(ChannelQuery.Channel query)
        {
            string route = $"{GetUrl("moderators")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Moderators>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<OnlineResult>> Online(ChannelQuery.Channel query)
        {
            string route = $"{GetUrl("online")}{query.ToQueryString()}";
            var response = await _restClientService.Get<OnlineResult>(route);
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

        public async Task<Result<Channel>> Rename(Payload.Rename payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("rename"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<RolesResult>> Roles(ChannelQuery.Channel query)
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

        public async Task<Result<Channel>> SetCustomFields(Payload.SetCustomFields payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("setCustomFields"), payload);
            return ProcessChannelResponse(response);
        }

        public void SetDefault() => throw new NotImplementedException();

        public async Task<Result<Channel>> SetDescription(Payload.SetDescription payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("setDescription"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> SetJoinCode(Payload.SetJoinCode payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("setJoinCode"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> SetPurpose(Payload.SetPurpose payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("setPurpose"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> SetReadOnly(Payload.SetReadOnly payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("setReadOnly"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> SetTopic(Payload.SetTopic payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("setTopic"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<Channel>> SetType(Payload.SetType payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("setType"), payload);
            return ProcessChannelResponse(response);
        }

        public async Task<Result<bool>> Unarchive(Payload payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("unarchive"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        private static Result<IEnumerable<Channel>> ProcessChannelsResponse(ApiResponse<ChannelsResult> response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Result.Success
                    ? new Result<IEnumerable<Channel>>(response.Result._Channels)
                    : new ErrorResult<IEnumerable<Channel>>(response.Message);
            }
            else
                return new ErrorResult<IEnumerable<Channel>>(response.Message);
        }

        private static Result<Channel> ProcessChannelResponse(ApiResponse<ChannelResult> response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Result.Success
                    ? new Result<Channel>(response.Result.Channel)
                    : new ErrorResult<Channel>(response.Message);
            }
            else
                return new ErrorResult<Channel>(response.Message);
        }
    }
}