using System.Threading.Tasks;
using Rocket.Chat.Domain;

namespace Rocket.Chat.Api.Core.Services
{
    public  interface IAssetsService
    {
        /// <summary>
        /// Set an asset image by name.
        /// </summary>
        Task<Result<bool>> SetAsset(Asset asset, bool refreshAllClients);
        /// <summary>
        /// Unset an asset by name.
        /// </summary>
        Task<Result<bool>> UnsetAsset(Asset asset, bool refreshAllClients);
    }
}