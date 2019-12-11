using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services.Helpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.Payloads;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{
    internal class AssetsService : IAssetsService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"assets.{endPoint}");

        private readonly IRestClientService _restClientService;

        public AssetsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<bool>> SetAsset(Asset asset, bool refreshAllClients)
        {
            var payload = new Payload.Asset { AssetName = asset.ToString(), RefreshAllClients = refreshAllClients };
            var response = await _restClientService.Post<CallResult>(GetUrl("setAsset"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> UnsetAsset(Asset asset, bool refreshAllClients)
        {
            var payload = new Payload.Asset { AssetName = asset.ToString(), RefreshAllClients = refreshAllClients };
            var response = await _restClientService.Post<CallResult>(GetUrl("unsetAsset"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }
    }
}