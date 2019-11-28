using System.Diagnostics.CodeAnalysis;
using Rocket.Chat.Domain.Interfaces;

namespace Rocket.Chat.Domain.LoginOptions
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class ResumeLoginOption : ILoginOption
    {
        /// <summary>
        /// Active login token given from a successful, previous login.
        /// </summary>
        public string Token { get; set; }
    }
}