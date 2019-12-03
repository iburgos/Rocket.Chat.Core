using System.Collections.Generic;

namespace Rocket.Chat.Domain.Payloads
{
    public class Payload
    {
        public string roomId { get; set; }
        public class AddAll : Payload
        {
            public bool activeUsersOnly { get; set; }
        }

        public class UserAction : Payload
        {
            public string userId { get; set; }
        }

        public class Create : Payload
        {
            public string name { get; set; }
            public IEnumerable<string> members { get; set; }
            public bool readOnly { get; set; }
        }

        public class Join : Payload
        {
            public string joinCode { get; set; }
        }

        public class Rename : Payload
        {
            public string name { get; set; }
        }

        public class SetAnnouncement : Payload
        {
            public string announcement { get; set; }
        }

        public class CustomFields : Payload
        {
            public string roomName { get; set; }

            public string customFields { get; set; }
        }

        public class SetDescription : Payload
        {
            public string description { get; set; }
        }

        public class SetJoinCode : Payload
        {
            public string joinCode { get; set; }
        }

        public class SetPurpose : Payload
        {
            public string purpose { get; set; }
        }

        public class SetReadOnly : Payload
        {
            public bool readOnly { get; set; }
        }

        public class SetTopic : Payload
        {
            public string topic { get; set; }
        }

        public class SetType : Payload
        {
            /// <summary>
            /// The type of room this channel should be, either c or p.
            /// </summary>
            public string type { get; set; }
        }
    }
}