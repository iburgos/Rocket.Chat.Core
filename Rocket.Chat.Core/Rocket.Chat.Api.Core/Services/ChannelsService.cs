using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services.Helpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Channels;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IChannelsService
    {
        /// <summary>
        /// Adds all of the users on the server to a channel.
        /// </summary>
        Task<Result<ChannelResult>> AddAll(ChannelsPayload.AddAll payload);
        /// <summary>
        /// Gives the role of Leader for a user in the current channel.
        /// </summary>
        Task<Result<bool>> AddLeader(string roomId, string userId);
        /// <summary>
        /// Gives the role of moderator for a user in the current channel.
        /// </summary>
        Task<Result<bool>> AddModerator(string roomId, string userId);
        /// <summary>
        /// Gives the role of owner for a user in the current channel.
        /// </summary>
        Task<Result<bool>> AddOwner(string roomId, string userId);
        /// <summary>
        /// Gets the messages in public channels to an anonymous user
        /// </summary>
        Task<Result<Messages>> AnonymousRead(Query query);
        /// <summary>
        /// Archives a channel.
        /// </summary>
        Task<Result<bool>> Archive(string roomId);
        /// <summary>
        /// Removes a channel from a user’s list of channels.
        /// </summary>
        Task<Result<bool>> Close(string roomId);
        /// <summary>
        /// Gets channel counters.
        /// </summary>
        Task<Result<Counters>> Counters(ChannelQuery.Counters query);
        /// <summary>
        /// Creates a new channel.
        /// </summary>
        Task<Result<ChannelResult>> Create(ChannelsPayload.Create payload);
        /// <summary>
        /// Removes a channel.
        /// </summary>
        Task<Result<bool>> Delete(string roomId);
        /// <summary>
        /// Gets a list of files from a channel.
        /// </summary>
        Task<Result<Files>> Files(ChannelQuery.Channel query);
        /// <summary>
        /// Gets all the mentions of a channel.
        /// </summary>
        Task<Result<Mentions>> GetAllUserMentionsByChannel(string roomId);
        /// <summary>
        /// Gets the channel’s integration.
        /// </summary>
        Task<Result<Integrations>> GetIntegrations(string roomId);
        /// <summary>
        /// Retrieves the messages from a channel.
        /// </summary>
        Task<Result<Messages>> History(ChannelQuery.History query);
        /// <summary>
        /// Gets a channel’s information.
        /// </summary>
        Task<Result<ChannelResult>> Info(string roomId);
        /// <summary>
        /// Adds a user to a channel.
        /// </summary>
        Task<Result<ChannelResult>> Invite(ChannelsPayload.Invite payload);
        /// <summary>
        /// Joins yourself to a channel.
        /// </summary>
        Task<Result<ChannelResult>> Join(ChannelsPayload.Join payload);
        /// <summary>
        /// Removes a user from a channel.
        /// </summary>
        Task<Result<ChannelResult>> Kick(ChannelsPayload.Kick payload);
        /// <summary>
        /// Removes the calling user from a channel.
        /// </summary>
        Task<Result<ChannelResult>> Leave(ChannelsPayload payload);
        /// <summary>
        /// Retrieves all of the channels from the server.
        /// </summary>
        Task<Result<Channels>> List();
        /// <summary>
        /// Gets only the channels the calling user has joined.
        /// </summary>
        Task<Result<Channels>> ListJoined();
        /// <summary>
        /// Retrieves all channel users.
        /// </summary>
        Task<Result<Members>> Members(ChannelQuery.Members query);
        /// <summary>
        /// Retrieves all channel messages.
        /// </summary>
        Task<Result<Messages>> Messages(string roomId);
        /// <summary>
        /// List all moderators of a channel.
        /// </summary>
        Task<Result<Moderators>> Moderators(ChannelQuery.Channel query);
        /// <summary>
        /// List all online users of a channel.
        /// </summary>
        Task<Result<OnlineResult>> Online(ChannelQuery.Channel query);
        /// <summary>
        /// Adds the channel back to the user’s list of channels.
        /// </summary>
        void Open();
        /// <summary>
        /// Removes the role of Leader for a user in the current channel.
        /// </summary>
        void Removeleader();
        /// <summary>
        /// Changes a channel’s name.
        /// </summary>
        void Rename();
        /// <summary>
        /// Gets the user’s roles in the channel.
        /// </summary>
        void Roles();
        /// <summary>
        /// Sets a channel’s custom fields.
        /// </summary>
        void SetCustomFields();
        /// <summary>
        /// Sets a channel’s announcement.
        /// </summary>
        void SetAnnouncement();
        /// <summary>
        /// Sets whether a channel is a default channel or not.
        /// </summary>
        void SetDefault();
        /// <summary>
        /// Sets a channel’s description.
        /// </summary>
        void SetDescription();
        /// <summary>
        /// Sets the channel’s code required to join it.
        /// </summary>
        void SetJoinCode();
        /// <summary>
        /// Sets a channel’s description.
        /// </summary>
        void SetPurpose();
        /// <summary>
        /// Sets whether a channel is read only or not.
        /// </summary>
        void SetReadOnly();
        /// <summary>
        /// Sets a channel’s topic.
        /// </summary>
        void SetTopic();
        /// <summary>
        /// Sets the type of room the channel should be.
        /// </summary>
        void SetType();
        /// <summary>
        /// Unarchives a channel.
        /// </summary>
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

        public async Task<Result<ChannelResult>> AddAll(ChannelsPayload.AddAll payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("addAll"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> AddLeader(string roomId, string userId)
        {
            var payload = new ChannelsPayload.AddUserRole { roomId = roomId, userId = userId };
            return await ProcessBooleanRequest(GetUrl("addLeader"), payload);
        }

        public async Task<Result<bool>> AddModerator(string roomId, string userId)
        {
            var payload = new ChannelsPayload.AddUserRole { roomId = roomId, userId = userId };
            return await ProcessBooleanRequest(GetUrl("addModerator"), payload);
        }

        public async Task<Result<bool>> AddOwner(string roomId, string userId)
        {
            var payload = new ChannelsPayload.AddUserRole { roomId = roomId, userId = userId };
            return await ProcessBooleanRequest(GetUrl("addOwner"), payload);
        }

        public async Task<Result<Messages>> AnonymousRead(Query query)
        {
            string route = $"{GetUrl("anonymousread")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Archive(string roomId)
        {
            return await ProcessBooleanRequest(GetUrl("archive"), new ChannelsPayload { roomId = roomId });
        }

        public async Task<Result<bool>> Close(string roomId)
        {
            return await ProcessBooleanRequest(GetUrl("close"), new ChannelsPayload { roomId = roomId });
        }

        public async Task<Result<Counters>> Counters(ChannelQuery.Counters query)
        {
            string route = $"{GetUrl("counters")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Counters>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<ChannelResult>> Create(ChannelsPayload.Create payload)
        {
            var response = await _restClientService.Post<ChannelResult>(GetUrl("create"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Delete(string roomId)
        {
            return await ProcessBooleanRequest(GetUrl("delete"), new ChannelsPayload { roomId = roomId });
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

        public async Task<Result<ChannelResult>> Info(string roomId)
        {
            var query = new ChannelQuery.Channel { RoomId = roomId };
            string route = $"{GetUrl("info")}{query.ToQueryString()}";
            return ServiceHelper.MapResponse(await _restClientService.Get<ChannelResult>(route));
        }

        public async Task<Result<ChannelResult>> Invite(ChannelsPayload.Invite payload)
        {
            return ServiceHelper.MapResponse(await _restClientService.Post<ChannelResult>(GetUrl("invite"), payload));
        }

        public async Task<Result<ChannelResult>> Join(ChannelsPayload.Join payload)
        {
            return ServiceHelper.MapResponse(await _restClientService.Post<ChannelResult>(GetUrl("join"), payload));
        }

        public async Task<Result<ChannelResult>> Kick(ChannelsPayload.Kick payload)
        {
            return ServiceHelper.MapResponse(await _restClientService.Post<ChannelResult>(GetUrl("kick"), payload));
        }

        public async Task<Result<ChannelResult>> Leave(ChannelsPayload payload)
        {
            return ServiceHelper.MapResponse(await _restClientService.Post<ChannelResult>(GetUrl("leave"), payload));
        }

        public async Task<Result<Channels>> List()
        {
            var response = await _restClientService.Get<Channels>(GetUrl("list"));
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Channels>> ListJoined()
        {
            var response = await _restClientService.Get<Channels>(GetUrl("list.joined"));
            return ServiceHelper.MapResponse(response);
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

        private async Task<Result<bool>> ProcessBooleanRequest(string url, object payload)
        {
            var response = await _restClientService.Post<CallResult>(url, payload);

            Result<bool> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = response.Result.Success ? new Result<bool>(true) : new Result<bool>(response.Result.Error);
            else
                loginResult = new Result<bool>(response.Message);

            return loginResult;
        }
    }
}