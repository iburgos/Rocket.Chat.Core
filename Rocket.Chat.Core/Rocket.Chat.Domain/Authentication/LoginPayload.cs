namespace Rocket.Chat.Domain.Authentication
{
    public class LoginPayload
    {
        public string serviceName { get; set; }
        public string accessToken { get; set; }
        public int expiresIn { get; set; }

        public class GoogleLogin : LoginPayload
        {
            public string idToken { get; set; }
            public string scope { get; set; }
        }

        public class FacebookLogin : LoginPayload
        {
            public string secret { get; set; }
        }

        public class TwitterLogin : LoginPayload
        {
            public string accessTokenSecret { get; set; }
            public string appSecret { get; set; }
            public string appId { get; set; }
        }
    }
}