using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services.Helpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Chat;
using Rocket.Chat.Domain.Payloads;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{
    internal class AutoTranslateService : IAutoTranslateService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"autotranslate.{endPoint}");

        private readonly IRestClientService _restClientService;

        public AutoTranslateService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<Languages>> GetSupportedLanguages(string targetLanguage = null)
        {
            string url = GetUrl("getSupportedLanguages");
            string route = string.IsNullOrEmpty(targetLanguage) ? url : $"{url}?targetLanguage={targetLanguage}";
            var response = await _restClientService.Get<Languages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> SaveSetttings(Payload.AutoTranslateSettings payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("saveSetttings"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<MessageResult>> TranslateMessage(string messageId, string targetLanguage)
        {
            var payload = new Payload.TranslateMessage { MessageId = messageId, TargetLanguage = targetLanguage };
            var response = await _restClientService.Post<MessageResult>(GetUrl("translateMessage"), payload);
            return ServiceHelper.MapResponse(response);
        }
    }
}