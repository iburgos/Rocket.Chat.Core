namespace Rocket.Chat.Domain.Authentication
{
    public class ServiceLoginRequest
    {
        public string serviceName { get; set; }
        public string accessToken { get; set; }
        public int expiresIn { get; set; }

        public class GoogleLogin : ServiceLoginRequest
        {
            public GoogleLogin(string _accessToken, int _expiresIn, string _idToken, string _scope)
            {
                serviceName = "google";
                accessToken = _accessToken;
                expiresIn = _expiresIn;
                idToken = _idToken;
                scope = _scope;
            }

            public string idToken { get; set; }
            public string scope { get; set; }
        }

        public class FacebookLogin : ServiceLoginRequest
        {
            public FacebookLogin(string _accessToken, int _expiresIn, string _secret)
            {
                serviceName = "facebook";
                accessToken = _accessToken;
                expiresIn = _expiresIn;
                secret = _secret;
            }
            public string secret { get; set; }
        }

        public class TwitterLogin : ServiceLoginRequest
        {
            public TwitterLogin(string _accessToken, int _expiresIn, string _accessTokenSecret, string _appSecret, string _appId)
            {
                serviceName = "twitter";
                accessToken = _accessToken;
                expiresIn = _expiresIn;
                accessTokenSecret = _accessTokenSecret;
                appSecret = _appSecret;
                appId = _appId;
            }

            public string accessTokenSecret { get; set; }
            public string appSecret { get; set; }
            public string appId { get; set; }
        }
    }
}