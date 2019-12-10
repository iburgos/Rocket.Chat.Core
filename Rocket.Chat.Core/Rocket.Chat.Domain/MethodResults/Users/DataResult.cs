using Rocket.Chat.Domain.Authentication;

namespace Rocket.Chat.Domain.MethodResults
{
    public class DataResult
    {
        public LoginData Data { get; set; }
        public bool Success { get; set; }
    }
}
