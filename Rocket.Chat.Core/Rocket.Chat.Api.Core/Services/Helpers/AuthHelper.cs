using Microsoft.Extensions.Caching.Memory;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IAuthHelper
    {
        bool IsAuthorized { get; }
        string UserId { get; }
        string AuthToken { get; }
    }

    public class AuthHelper: IAuthHelper
    {
        public bool IsAuthorized { get { return _isAuthorized;  } }
        public string UserId { get { return _userId; } }
        public string AuthToken { get { return _authToken; } }

        private readonly IMemoryCache _memoryCache;

        public AuthHelper(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        private bool _isAuthorized => _memoryCache.TryGetValue(CacheHelper.AUTHORIZED_KEY, out bool isAuthorized) ? isAuthorized : false;

        private string _userId => _memoryCache.TryGetValue(CacheHelper.USER_ID_KEY, out string userId) ? userId : string.Empty;

        private string _authToken => _memoryCache.TryGetValue(CacheHelper.AUTH_TOKEN_KEY, out string authToken) ? authToken : string.Empty;
    }
}
