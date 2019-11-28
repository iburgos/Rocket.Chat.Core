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
        Task<Result<ChannelsResult>> ListJoined();
    }

    public class RocketChatApi : IRocketChatApi
    {
        private readonly IChannelsService _channelsService;
        private readonly ILoginService _loginService;

        public RocketChatApi(
            IChannelsService channelsService,
            ILoginService loginService)
        {
            _channelsService = channelsService;
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

        public async Task<Result<ChannelsResult>> ListJoined()
        {
            return await _channelsService.ListJoined();
        }
    }
}