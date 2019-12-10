using Rocket.Chat.Domain.Authentication;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
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