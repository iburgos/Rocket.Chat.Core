using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Channels;
using Rocket.Chat.Domain.Payloads.Channels;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IChannelsService
    {
        /// <summary>
        /// Adds all of the users on the server to a channel.
        /// </summary>
        Task<Result<ChannelResult>> AddAll(string roomId, bool activeUsersOnly = false);
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
        void Anonymousread();
        /// <summary>
        /// Archives a channel.
        /// </summary>
        void Archive();
        /// <summary>
        /// Cleans up a channel’s history, requires special permission.
        /// </summary>
        void CleanHistory();
        /// <summary>
        /// Removes a channel from a user’s list of channels.
        /// </summary>
        void Close();
        /// <summary>
        /// Gets channel counters.
        /// </summary>
        void Counters();
        /// <summary>
        /// Creates a new channel.
        /// </summary>
        void Create();
        /// <summary>
        /// Removes a channel.
        /// </summary>
        void Delete();
        /// <summary>
        /// Gets a list of files from a channel.
        /// </summary>
        void Files();
        /// <summary>
        /// Gets all the mentions of a channel.
        /// </summary>
        void GetAllUserMentionsByChannel();
        /// <summary>
        /// Gets the channel’s integration.
        /// </summary>
        void GetIntegrations();
        /// <summary>
        /// Retrieves the messages from a channel.
        /// </summary>
        Task<Result<Messages>> History(string roomId);
        /// <summary>
        /// Gets a channel’s information.
        /// </summary>
        void Info();
        /// <summary>
        /// Adds a user to a channel.
        /// </summary>
        void Invite();
        /// <summary>
        /// Joins yourself to a channel.
        /// </summary>
        void Join();
        /// <summary>
        /// Removes a user from a channel.
        /// </summary>
        void Kick();
        /// <summary>
        /// Removes the calling user from a channel.
        /// </summary>
        void Leave();
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
        void Members();
        /// <summary>
        /// Retrieves all channel messages.
        /// </summary>
        Task<Result<Messages>> Messages(string roomId);
        /// <summary>
        /// 
        /// </summary>
        void Moderators();
        /// <summary>
        /// List all moderators of a channel.
        /// </summary>
        void Online();
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

        public async Task<Result<ChannelResult>> AddAll(string roomId, bool activeUsersOnly = false)
        {
            var payload = new ChannelsPayload.AddAll
            {
                roomId = roomId,
                activeUsersOnly = activeUsersOnly
            };

            var response = await _restClientService.Post<ChannelResult>(GetUrl("addAll"), payload);

            Result<ChannelResult> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<ChannelResult>(response.Result);
            else
                loginResult = new Result<ChannelResult>(response.Message);

            return loginResult;
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

        public async Task<Result<Messages>> AnonymousRead(string roomId = "", string roomName = "")
        {
            string route = GetUrl("anonymousread");
            if (!string.IsNullOrEmpty(roomId))
                route += $"?roomId={roomId}";
            else if (!string.IsNullOrEmpty(roomName) && !route.Contains("roomId"))
                route += $"?roomName={roomName}";

            var response = await _restClientService.Get<Messages>(route);

            Result<Messages> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Messages>(response.Result);
            else
                loginResult = new Result<Messages>(response.Message);

            return loginResult;
        }
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