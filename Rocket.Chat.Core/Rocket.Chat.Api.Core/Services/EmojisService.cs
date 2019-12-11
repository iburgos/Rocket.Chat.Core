using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services.Helpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{
    internal class EmojisService : IEmojisService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"emoji-custom.{endPoint}");

        private readonly IRestClientService _restClientService;
        private readonly IFileRestClientService _fileRestClientService;

        public EmojisService(
            IRestClientService restClientService,
            IFileRestClientService fileRestClientService)
        {
            _restClientService = restClientService;
            _fileRestClientService = fileRestClientService;
        }

        public async Task<Result<Emojis>> List(DateTime? updatedSince = null)
        {
            string route = updatedSince.HasValue ? $"{GetUrl("list")}?updatedSince={updatedSince.Value.ToString(QueryHelper.DATE_FORMAT)}" : GetUrl("list");
            var response = await _restClientService.Get<Emojis>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Create(Payload.CreateEmoji payload)
        {
            var response = await _fileRestClientService.CreateEmoji<CallResult>(GetUrl("create"), payload.Name, payload.Aliases, payload.Emoji);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> Delete(string emojiId)
        {
            var payload = new Payload.DeleteEmoji { EmojiId = emojiId };
            var response = await _restClientService.Post<CallResult>(GetUrl("delete"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> Update(Payload.UpdateEmoji payload)
        {
            var response = await _fileRestClientService.CreateEmoji<CallResult>(GetUrl("update"), payload.Name, payload.Aliases, payload.Emoji);
            return ServiceHelper.MapBoolResponse(response);
        }
    }
}