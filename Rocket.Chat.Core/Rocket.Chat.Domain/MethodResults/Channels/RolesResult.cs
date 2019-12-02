using System.Collections.Generic;

namespace Rocket.Chat.Domain.MethodResults.Channels
{
    public class RolesResult
    {
        public IEnumerable<Role> Roles { get; set; }
        public bool Success { get; set; }
    }
}