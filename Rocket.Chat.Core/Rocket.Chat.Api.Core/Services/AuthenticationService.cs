using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Domain.Authentication;
using Rocket.Chat.Domain.Requests;
using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{
    internal class AuthenticationService: IAuthenticationService
    {
        private readonly IAuthHelper _authHelper;
        private readonly IRestClientService _restClientService;

        public AuthenticationService(
            IAuthHelper authHelper,
            IRestClientService restClientService)
        {
            _authHelper = authHelper;
            _restClientService = restClientService;
        }

        public async Task<Result<LoginResult>> Login(string user, string password)
        {
            var loginRequest = new LoginRequest
            {
                User = user,
                Password = password
            };

            ApiResponse<LoginResult> response = await _restClientService.Post<LoginResult>(ApiHelper.GetUrl("login"), loginRequest);

            Result<LoginResult> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                loginResult = new Result<LoginResult>(response.Result);
                var loginData = loginResult.Content.Data;
                _authHelper.IsAuthorized = true;
                _authHelper.UserId = loginData.UserId;
                _authHelper.AuthToken = loginData.AuthToken;
            }
            else
                loginResult = new ErrorResult<LoginResult>(response.Message);

            return loginResult;
        }

        public void LoginGoogle()
        {
            throw new NotImplementedException();
        }

        public void LoginFacebook()
        {
            throw new NotImplementedException();
        }

        public void LoginTwitter()
        {
            throw new NotImplementedException();
        }

        public async Task<Result<LogoutResult>> Logout()
        {
            ApiResponse<LogoutResult> response = await _restClientService.Post<LogoutResult>(ApiHelper.GetUrl("logout"), null);

            Result<LogoutResult> logoutResult;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                logoutResult = new Result<LogoutResult>(response.Result);
                _authHelper.IsAuthorized = false;
                _authHelper.UserId = string.Empty;
                _authHelper.AuthToken = string.Empty;
            }
            else
                logoutResult = new ErrorResult<LogoutResult>(response.Message);

            return logoutResult;
        }

        public void Me()
        {
            throw new NotImplementedException();
        }
    }
}