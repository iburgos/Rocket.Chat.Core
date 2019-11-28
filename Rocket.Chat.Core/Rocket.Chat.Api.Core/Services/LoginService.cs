using Microsoft.Extensions.Caching.Memory;
using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Login;
using Rocket.Chat.Domain.Requests;
using System.Net;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface ILoginService
    {
        Task<Result<LoginResult>> Login(string user, string password);
        Task<Result<LogoutResult>> Logout();
    }

    internal class LoginService: ILoginService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IRestClientService _restClientService;

        public LoginService(
            IMemoryCache memoryCache,
            IRestClientService restClientService)
        {
            _memoryCache = memoryCache;
            _restClientService = restClientService;
        }

        public async Task<Result<LoginResult>> Login(string user, string password)
        {
            var loginRequest = new LoginRequest
            {
                user = user,
                password = password
            };

            ApiResponse<LoginResult> response = await _restClientService.Post<LoginResult>(ApiHelper.GetUrl("login"), loginRequest);

            Result<LoginResult> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                loginResult = new Result<LoginResult>(response.Result);
                var loginData = loginResult.Content.Data;
                _memoryCache.Set(CacheHelper.AUTHORIZED_KEY, true);
                _memoryCache.Set(CacheHelper.USER_ID_KEY, loginData.UserId);
                _memoryCache.Set(CacheHelper.AUTH_TOKEN_KEY, loginData.AuthToken);
            }
            else
                loginResult = new Result<LoginResult>(response.Message);

            return loginResult;
        }

        public async Task<Result<LogoutResult>> Logout()
        {
            ApiResponse<LogoutResult> response = await _restClientService.Post<LogoutResult>(ApiHelper.GetUrl("logout"), null);

            Result<LogoutResult> logoutResult;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                logoutResult = new Result<LogoutResult>(response.Result);
                _memoryCache.Set(CacheHelper.AUTHORIZED_KEY, false);
                _memoryCache.Set(CacheHelper.USER_ID_KEY, string.Empty);
                _memoryCache.Set(CacheHelper.AUTH_TOKEN_KEY, string.Empty);
            }
            else
                logoutResult = new Result<LogoutResult>(response.Message);

            return logoutResult;
        }
    }
}