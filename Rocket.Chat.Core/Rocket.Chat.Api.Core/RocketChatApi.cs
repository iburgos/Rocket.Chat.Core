using Microsoft.Extensions.Caching.Memory;
using Rocket.Chat.Api.Core.Services;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Login;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core
{
    public interface IRocketChatApi
    {
        Task<Result<LoginResult>> Login(string user, string password);
        Task<Result<LogoutResult>> Logout();
    }

    public class RocketChatApi : IRocketChatApi
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILoginService _loginService;

        public RocketChatApi(
            IMemoryCache memoryCache,
            ILoginService loginService)
        {
            _memoryCache = memoryCache;
            _loginService = loginService;
        }

        public async Task<Result<LoginResult>> Login(string user, string password)
        {
            return await _loginService.Login(user, password);
        }

        public async Task<Result<LogoutResult>> Logout()
        {
            return await _loginService.Logout();
        }
    }
}
