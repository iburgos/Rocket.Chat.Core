using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults.Chat;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{
    public interface IChatService
    {
        /// <summary>
        /// Deletes an existing chat message.
        /// </summary>
        Task<Result<DeleteMessageResult>> DeleteMessage(Payload.DeleteMessage payload);
        /// <summary>
        /// Follows a chat message to the message’s channel.
        /// </summary>
        Task<Result<bool>> FollowMessage(Payload.FollowMessage payload);
        /// <summary>
        /// Retrieves the deleted messages since specific date.
        /// </summary>
        Task<Result<Messages>> GetDeletedMessages(ChatQuery.GetDeletedMessages query);
        /// <summary>
        /// Retrieves the mentioned messages.
        /// </summary>
        Task<Result<Messages>> GetMentionedMessages(string roomId);
        /// <summary>
        /// Retrieves a single chat message by the provided id. Callee must have permission to access the room where the message resides.
        /// </summary>
        Task<Result<MessageResult>> GetMessage(string messageId);
        /// <summary>
        /// Retrieves message read receipts.
        /// </summary>
        Task<Result<MessageReceipsResult>> GetMessageReadReceipts(string messageId);
        /// <summary>
        /// Retrieve pinned messages from a room.
        /// </summary>
        Task<Result<Messages>> GetPinnedMessages(ChatQuery.GetPinnedMessages query);
        /// <summary>
        /// Retrieves snippeted message by id.
        /// </summary>
        Task<Result<MessageResult>> GetSnippetedMessageById(string messageId);
        /// <summary>
        /// Retrieves the starred messages.
        /// </summary>
        Task<Result<Messages>> GetStarredMessages(ChatQuery.GetStarredMessages query);
        /// <summary>
        /// Retrieves thread’s messages.
        /// </summary>
        Task<Result<Messages>> GetThreadMessages(ChatQuery.GetThreadMessages query);
        /// <summary>
        /// Retrieves channel’s threads.
        /// </summary>
        Task<Result<Threads>> GetThreadsList(ChatQuery.GetThreadList query);
        /// <summary>
        /// Ignores an user from a chat.
        /// </summary>
        Task<Result<bool>> IgnoreUser(ChatQuery.IgnoreUser query);
        /// <summary>
        /// Pins a chat message to the message’s channel.	
        /// </summary>
        Task<Result<MessageResult>> PinMessage(string messageId);
        /// <summary>
        /// Posts a new chat message.
        /// </summary>
        Task<Result<PostMessageResult>> PostMessage(Payload.PostMessage payload);
        /// <summary>
        /// Sets/unsets the user’s reaction to an existing chat message.
        /// </summary>
        Task<Result<bool>> React(Payload.React payload);
        /// <summary>
        /// Reports a message.
        /// </summary>
        Task<Result<bool>> ReportMessage(Payload.ReportMessage payload);
        /// <summary>
        /// Search for messages in a channel.
        /// </summary>
        Task<Result<Messages>> Search(ChatQuery.Search query);
        /// <summary>
        /// Stars a chat message for the authenticated user.
        /// </summary>
        Task<Result<bool>> StarMessage(string messageId);
        /// <summary>
        /// Send new chat message.
        /// </summary>
        Task<Result<MessageResult>> SendMessage(Payload.SendMessage payload);
        /// <summary>
        /// Retrieves synced thread’s messages.
        /// </summary>
        Task<Result<Messages>> SyncThreadMessages(ChatQuery.SyncThreadMessages query);
        /// <summary>
        /// Retrieves thread’s synced channel threads.
        /// </summary>
        Task<Result<Threads>> SyncThreadsList(ChatQuery.SyncThreadList query);
        /// <summary>
        /// Unfollows an existing chat message.
        /// </summary>
        Task<Result<bool>> UnfollowMessage(string messageId);
        /// <summary>
        /// Removes the pinned status of the provided chat message.
        /// </summary>
        Task<Result<bool>> UnPinMessage(string messageId);
        /// <summary>
        /// Removes the star on the chat message for the authenticated user.
        /// </summary>
        Task<Result<bool>> UnStarMessage(string messageId);
        /// <summary>
        /// Updates the text of the chat message.
        /// </summary>
        Task<Result<MessageResult>> Update(Payload.Update payload);
    }
}