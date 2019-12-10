using System;
using System.Threading.Tasks;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults.Rooms;
using Rocket.Chat.Domain.Payloads;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IRoomService
    {
        Task<Result<bool>> CleanHistory(Payload.CleanHistory payload);
        Task<Result<DiscussionResult>> CreateDiscussion(Payload.CreateDiscussion payload);
        Task<Result<bool>> Favorite(string roomId, bool favorite);
        Task<Result<RoomsResult>> Get(DateTime? updatedSince = null);
        Task<Result<Discussions>> GetDiscussions(string roomId);
        Task<Result<RoomResult>> Info(string roomId);
        Task<Result<bool>> Leave(string roomId);
        Task<Result<bool>> SaveNotification(Payload.Notification payload);
    }
}