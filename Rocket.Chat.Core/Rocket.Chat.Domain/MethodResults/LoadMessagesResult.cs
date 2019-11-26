namespace Rocket.Chat.Domain.MethodResults
{
    using System.Collections.Generic;

    public class LoadMessagesResult
    {
        public List<RocketMessage> Messages { get; set; }
    }
}
