using System.Collections.Generic;

namespace Rocket.Chat.Domain.MethodResults.Rooms
{
    public class RoomsResult
    {
        public IEnumerable<Update> Update { get; set; }
        public IEnumerable<Update> Remove { get; set; }
        public bool Success { get; set; }
    }
}