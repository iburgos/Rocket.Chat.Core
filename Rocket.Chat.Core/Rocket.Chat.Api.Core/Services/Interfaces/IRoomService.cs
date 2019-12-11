using System;
using System.Threading.Tasks;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults.Rooms;
using Rocket.Chat.Domain.Payloads;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IRoomService
    {
        /// <summary>
        /// Cleans up a room’s history, requires special permission.
        /// </summary>
        Task<Result<bool>> CleanHistory(Payload.CleanHistory payload);
        /// <summary>
        /// Creates a new discussion.
        /// </summary>
        Task<Result<DiscussionResult>> CreateDiscussion(Payload.CreateDiscussion payload);
        /// <summary>
        /// Favorite/Unfavorite room.
        /// </summary>
        Task<Result<bool>> Favorite(string roomId, bool favorite);
        /// <summary>
        /// Gets rooms.
        /// </summary>
        Task<Result<RoomsResult>> Get(DateTime? updatedSince = null);
        /// <summary>
        /// Gets room’s discussions.
        /// </summary>
        Task<Result<Discussions>> GetDiscussions(string roomId);
        /// <summary>
        /// Gets info from a room.
        /// </summary>
        Task<Result<RoomResult>> Info(string roomId);
        /// <summary>
        /// Leaves a room.
        /// </summary>
        Task<Result<bool>> Leave(string roomId);
        /// <summary>
        /// Sets the notification settings of specific channel.
        /// </summary>
        Task<Result<bool>> SaveNotification(Payload.Notification payload);
    }
}