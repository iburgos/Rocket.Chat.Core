using System.Threading.Tasks;
using Rocket.Chat.Domain;

namespace Rocket.Chat.Api.Core.Services
{
    public  interface IAssetsService
    {
        Task<Result<bool>> SetAsset(Asset asset, bool refreshAllClients);
        Task<Result<bool>> UnsetAsset(Asset asset, bool refreshAllClients);
    }
}