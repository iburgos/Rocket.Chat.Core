namespace Rocket.Chat.Domain.Payloads
{
    public class ChannelsPayload
    {
        public string roomId { get; set; }
        public class AddAll : ChannelsPayload
        {
            public bool activeUsersOnly { get; set; }
        }

        public class AddUserRole : ChannelsPayload
        {
            public string userId { get; set; }
        }
    }
}
