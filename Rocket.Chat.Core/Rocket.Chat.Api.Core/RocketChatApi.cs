using Rocket.Chat.Api.Core.Services;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Login;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core
{
    public interface IRocketChatApi
    {
        Task<Result<LoginResult>> Login(string user, string password);
        Task<Result<LogoutResult>> Logout();
        Task<Result<Channels>> ListJoined();
        Task<Result<Messages>> Messages(string roomId);
        Task<Result<Messages>> History(string roomId);
    }

    public class RocketChatApi : IRocketChatApi
    {
        private readonly IChannelsService _channelsService;
        private readonly IAuthenticationService _loginService;

        public RocketChatApi(
            IChannelsService channelsService,
            IAuthenticationService loginService)
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

        public async Task<Result<Channels>> ListJoined()
        {
            return await _channelsService.ListJoined();
        }

        public async Task<Result<Messages>> Messages(string roomId)
        {
            return await _channelsService.Messages(roomId);
        }

        public async Task<Result<Messages>> History(string roomId)
        {
            return await _channelsService.History(roomId);
        }
    }
}