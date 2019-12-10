using System.Threading.Tasks;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults.Chat;
using Rocket.Chat.Domain.Payloads;

namespace Rocket.Chat.Api.Core.Services
{
    public  interface IAutoTranslateService
    {
        Task<Result<Languages>> GetSupportedLanguages(string targetLanguage = null);
        Task<Result<bool>> SaveSetttings(Payload.AutoTranslateSettings payload);
        Task<Result<MessageResult>> TranslateMessage(string messageId, string targetLanguage);
    }
}