using Rocket.Chat.Domain.Authentication;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Result<LoginResult>> Login(string user, string password);
        void LoginGoogle();
        void LoginFacebook();
        void LoginTwitter();
        Task<Result<LogoutResult>> Logout();
        void Me();
    }
}