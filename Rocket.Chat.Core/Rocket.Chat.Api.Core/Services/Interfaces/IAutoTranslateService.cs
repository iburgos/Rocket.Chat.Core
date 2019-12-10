using System.Threading.Tasks;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults.Chat;
using Rocket.Chat.Domain.Payloads;

namespace Rocket.Chat.Api.Core.Services
{
    public  interface IAutoTranslateService
    {
        /// <summary>
        /// Get the supported languages by the autotranslate.
        /// </summary>
        Task<Result<Languages>> GetSupportedLanguages(string targetLanguage = null);
        /// <summary>
        /// Save some settings about autotranslate.
        /// </summary>
        Task<Result<bool>> SaveSetttings(Payload.AutoTranslateSettings payload);
        /// <summary>
        /// Translate the message.
        /// </summary>
        Task<Result<MessageResult>> TranslateMessage(string messageId, string targetLanguage);
    }
}