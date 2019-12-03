namespace Rocket.Chat.Api.Core.Services
{
    public interface IAuthHelper
    {
        bool IsAuthorized { get; set; }
        string UserId { get; set; }
        string AuthToken { get; set; }
    }

    public class AuthHelper: IAuthHelper
    {
        public bool IsAuthorized { get; set; }
        public string UserId { get; set; }
        public string AuthToken { get; set; }
    }
}
