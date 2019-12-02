using System.Collections;
using System.Collections.Generic;

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

        public class Create : ChannelsPayload
        {
            public string name { get; set; }
            public IEnumerable<string> members { get; set; }
            public bool readOnly { get; set; }
        }

        public class Invite : ChannelsPayload
        {
            public string userId { get; set; }
        }

        public class Join : ChannelsPayload
        {
            public string joinCode { get; set; }
        }

        public class Kick : ChannelsPayload
        {
            public string userId { get; set; }
        }
    }
}