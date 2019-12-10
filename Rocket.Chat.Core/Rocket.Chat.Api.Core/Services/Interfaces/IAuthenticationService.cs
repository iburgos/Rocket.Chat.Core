using Rocket.Chat.Domain.Authentication;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// Authenticate with the REST API.
        /// </summary>
        Task<Result<LoginResult>> Login(string user, string password);
        /// <summary>
        /// Authenticate with google.
        /// </summary>
        void LoginGoogle();
        /// <summary>
        /// Authenticate with facebook.
        /// </summary>
        void LoginFacebook();
        /// <summary>
        /// Authenticate with twitter.
        /// </summary>
        void LoginTwitter();
        /// <summary>
        /// Invalidate your REST API authentication token.
        /// </summary>
        Task<Result<LogoutResult>> Logout();
        /// <summary>
        /// Displays information about the authenticated user.
        /// </summary>
        void Me();
    }
}