using System.Collections.Generic;

namespace Rocket.Chat.Domain.MethodResults.Channels
{
    public class OnlineResult
    {
        public IEnumerable<User> Online { get; set; }
        public bool Success { get; set; }
    }
}