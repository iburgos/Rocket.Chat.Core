using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services.Helpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Rooms;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;
using System;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    internal class RoomService : IRoomService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"rooms.{endPoint}");

        private readonly IRestClientService _restClientService;

        public RoomService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<bool>> CleanHistory(Payload.CleanHistory payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("cleanHistory"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<DiscussionResult>> CreateDiscussion(Payload.CreateDiscussion payload)
        {
            var response = await _restClientService.Post<DiscussionResult>(GetUrl("createDiscussion"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Favorite(string roomId, bool favorite)
        {
            var payload = new Payload.FavoriteRoom { RoomId = roomId, Favorite = favorite };
            var response = await _restClientService.Post<CallResult>(GetUrl("favorite"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<RoomsResult>> Get(DateTime? updatedSince = null)
        {
            string route = updatedSince.HasValue ? $"{GetUrl("get")}?updatedSince={updatedSince.Value.ToString(QueryHelper.DATE_FORMAT)}" : GetUrl("get");
            var response = await _restClientService.Get<RoomsResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Discussions>> GetDiscussions(string roomId)
        {
            string route = $"{GetUrl("getDiscussions")}?roomId={roomId}";
            var response = await _restClientService.Get<Discussions>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<RoomResult>> Info(string roomId)
        {
            string route = $"{GetUrl("info")}?roomId={roomId}";
            var response = await _restClientService.Get<RoomResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Leave(string roomId)
        {
            var payload = new Payload { RoomId = roomId };
            var response = await _restClientService.Post<CallResult>(GetUrl("leave"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> SaveNotification(Payload.Notification payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("saveNotification"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }
    }
}