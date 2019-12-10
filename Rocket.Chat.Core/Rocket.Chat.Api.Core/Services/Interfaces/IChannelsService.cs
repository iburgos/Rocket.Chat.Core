using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults.Channels;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IChannelsService
    {
        /// <summary>
        /// Adds all of the users on the server to a channel.
        /// </summary>
        Task<Result<ChannelResult>> AddAll(Payload.AddAll payload);
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
        Task<Result<Messages>> AnonymousRead(FullQuery query);
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
        Task<Result<ChannelResult>> Create(Payload.Create payload);
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
        Task<Result<ChannelResult>> Invite(Payload.UserAction payload);
        /// <summary>
        /// Joins yourself to a channel.
        /// </summary>
        Task<Result<ChannelResult>> Join(Payload.Join payload);
        /// <summary>
        /// Removes a user from a channel.
        /// </summary>
        Task<Result<ChannelResult>> Kick(Payload.UserAction payload);
        /// <summary>
        /// Removes the calling user from a channel.
        /// </summary>
        Task<Result<ChannelResult>> Leave(Payload payload);
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
        Task<Result<bool>> Open(string roomId);
        /// <summary>
        /// Removes the role of Leader for a user in the current channel.
        /// </summary>
        Task<Result<bool>> Removeleader(Payload.UserAction payload);
        /// <summary>
        /// Changes a channel’s name.
        /// </summary>
        Task<Result<ChannelResult>> Rename(Payload.Rename payload);
        /// <summary>
        /// Gets the user’s roles in the channel.
        /// </summary>
        Task<Result<RolesResult>> Roles(ChannelQuery.Channel query);
        /// <summary>
        /// Sets a channel’s announcement.
        /// </summary>
        Task<Result<AnnouncementResult>> SetAnnouncement(Payload.SetAnnouncement payload);
        /// <summary>
        /// Sets a channel’s custom fields.
        /// </summary>
        Task<Result<ChannelResult>> SetCustomFields(Payload.SetCustomFields payload);
        /// <summary>
        /// Sets whether a channel is a default channel or not.
        /// </summary>
        void SetDefault();
        /// <summary>
        /// Sets a channel’s description.
        /// </summary>
        Task<Result<ChannelResult>> SetDescription(Payload.SetDescription payload);
        /// <summary>
        /// Sets the channel’s code required to join it.
        /// </summary>
        Task<Result<ChannelResult>> SetJoinCode(Payload.SetJoinCode payload);
        /// <summary>
        /// Sets a channel’s description.
        /// </summary>
        Task<Result<ChannelResult>> SetPurpose(Payload.SetPurpose payload);
        /// <summary>
        /// Sets whether a channel is read only or not.
        /// </summary>
        Task<Result<ChannelResult>> SetReadOnly(Payload.SetReadOnly payload);
        /// <summary>
        /// Sets a channel’s topic.
        /// </summary>
        Task<Result<ChannelResult>> SetTopic(Payload.SetTopic payload);
        /// <summary>
        /// Sets the type of room the channel should be.
        /// </summary>
        Task<Result<ChannelResult>> SetType(Payload.SetType payload);
        /// <summary>
        /// Unarchives a channel.
        /// </summary>
        Task<Result<bool>> Unarchive(Payload payload);
    }
}