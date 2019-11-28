using Rocket.Chat.Domain.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Rocket.Chat.Domain.LoginOptions
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class LdapLoginOption : ILoginOption
    {
        /// <summary>
        /// Username of the user to login as. Do not include the domain in which this user resides. 
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Plaintext password of the user. 
        /// </summary>
        public string Password { get; set; }
    }
}