using Rocket.Chat.Api.Core.RestHelpers;
using System;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IUsersService
    {
        void Presence();
        void Create();
        void CreateToken();
        void Delete();
        void DeleteOwnAccount();
        void ForgotPassword();
        void GeneratePersonalAccessToken();
        void GetAvatar();
        void GetPersonalAccessTokens();
        void GetPreferences();
        void GetPresence();
        void GetUsernameSuggestion();
        void Info();
        void List();
        void RegeneratePersonalAccessToken();
        void Register();
        void RemovePersonalAccessToken();
        void RequestDataDownload();
        void ResetAvatar();
        void SetAvatar();
        void SetPreferences();
        void SetActiveStatus();
        void Update();
        void UpdateOwnBasicInfo();
    }

    public class UsersService: IUsersService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"users.{endPoint}");

        private readonly IRestClientService _restClientService;

        public UsersService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public void Presence() => throw new NotImplementedException();
        public void Create() => throw new NotImplementedException();
        public void CreateToken() => throw new NotImplementedException();
        public void Delete() => throw new NotImplementedException();
        public void DeleteOwnAccount() => throw new NotImplementedException();
        public void ForgotPassword() => throw new NotImplementedException();
        public void GeneratePersonalAccessToken() => throw new NotImplementedException();
        public void GetAvatar() => throw new NotImplementedException();
        public void GetPersonalAccessTokens() => throw new NotImplementedException();
        public void GetPreferences() => throw new NotImplementedException();
        public void GetPresence() => throw new NotImplementedException();
        public void GetUsernameSuggestion() => throw new NotImplementedException();
        public void Info() => throw new NotImplementedException();
        public void List() => throw new NotImplementedException();
        public void RegeneratePersonalAccessToken() => throw new NotImplementedException();
        public void Register() => throw new NotImplementedException();
        public void RemovePersonalAccessToken() => throw new NotImplementedException();
        public void RequestDataDownload() => throw new NotImplementedException();
        public void ResetAvatar() => throw new NotImplementedException();
        public void SetAvatar() => throw new NotImplementedException();
        public void SetPreferences() => throw new NotImplementedException();
        public void SetActiveStatus() => throw new NotImplementedException();
        public void Update() => throw new NotImplementedException();
        public void UpdateOwnBasicInfo() => throw new NotImplementedException();
    }
}