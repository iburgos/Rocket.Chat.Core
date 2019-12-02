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

        public class UserAction : ChannelsPayload
        {
            public string userId { get; set; }
        }

        public class Create : ChannelsPayload
        {
            public string name { get; set; }
            public IEnumerable<string> members { get; set; }
            public bool readOnly { get; set; }
        }

        public class Join : ChannelsPayload
        {
            public string joinCode { get; set; }
        }

        public class Rename : ChannelsPayload
        {
            public string name { get; set; }
        }

        public class SetAnnouncement : ChannelsPayload
        {
            public string announcement { get; set; }
        }

        public class CustomFields : ChannelsPayload
        {
            public string roomName { get; set; }

            public string customFields { get; set; }
        }

        public class SetDescription : ChannelsPayload
        {
            public string description { get; set; }
        }

        public class SetJoinCode : ChannelsPayload
        {
            public string joinCode { get; set; }
        }

        public class SetPurpose : ChannelsPayload
        {
            public string purpose { get; set; }
        }

        public class SetReadOnly : ChannelsPayload
        {
            public bool readOnly { get; set; }
        }

        public class SetTopic : ChannelsPayload
        {
            public string topic { get; set; }
        }

        public class SetType : ChannelsPayload
        {
            /// <summary>
            /// The type of room this channel should be, either c or p.
            /// </summary>
            public string type { get; set; }
        }
    }
}