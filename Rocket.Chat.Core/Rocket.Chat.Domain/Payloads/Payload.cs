using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain.Payloads
{
    public class Payload
    {
        [JsonProperty(PropertyName = "roomId")]
        public string RoomId { get; set; }

        public class AddAll : Payload
        {
            [JsonProperty(PropertyName = "activeUsersOnly")]
            public bool ActiveUsersOnly { get; set; }
        }

        public class UserAction : Payload
        {
            [JsonProperty(PropertyName = "userId")]
            public string UserId { get; set; }
        }

        public class Create : Payload
        {
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "members")]
            public IEnumerable<string> Members { get; set; }

            [JsonProperty(PropertyName = "readOnly")]
            public bool ReadOnly { get; set; }
        }

        public class Join : Payload
        {
            [JsonProperty(PropertyName = "joinCode")]
            public string JoinCode { get; set; }
        }

        public class Rename : Payload
        {
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }
        }

        public class SetAnnouncement : Payload
        {
            [JsonProperty(PropertyName = "announcement")]
            public string Announcement { get; set; }
        }

        public class SetCustomFields : Payload
        {
            [JsonProperty(PropertyName = "roomName")]
            public string RoomName { get; set; }

            [JsonProperty(PropertyName = "customFields")]
            public string CustomFields { get; set; }
        }

        public class SetDescription : Payload
        {
            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }
        }

        public class SetJoinCode : Payload
        {
            [JsonProperty(PropertyName = "joinCode")]
            public string JoinCode { get; set; }
        }

        public class SetPurpose : Payload
        {
            [JsonProperty(PropertyName = "purpose")]
            public string Purpose { get; set; }
        }

        public class SetReadOnly : Payload
        {
            [JsonProperty(PropertyName = "readOnly")]
            public bool ReadOnly { get; set; }
        }

        public class SetTopic : Payload
        {
            [JsonProperty(PropertyName = "topic")]
            public string Topic { get; set; }
        }

        public class SetType : Payload
        {
            /// <summary>
            /// The type of room this channel should be, either c or p.
            /// </summary>
            [JsonProperty(PropertyName = "type")]
            public string Type { get; set; }
        }

        public class DeleteMessage: Payload
        {
            [JsonProperty(PropertyName = "messageId")]
            public string MessageId { get; set; }

            [JsonProperty(PropertyName = "asUser")]
            public bool AsUser { get; set; }
        }

        public class FollowMessage : Payload
        {
            [JsonProperty(PropertyName = "mid")]
            public string MessageId { get; set; }
        }

        public class PinMessage : Payload
        {
            [JsonProperty(PropertyName = "messageId")]
            public string MessageId { get; set; }
        }

        public class StarMessage : Payload
        {
            [JsonProperty(PropertyName = "messageId")]
            public string MessageId { get; set; }
        }

        public class PostMessage : Payload
        {
            [JsonProperty(PropertyName = "channel")]
            public string Channel { get; set; }

            [JsonProperty(PropertyName = "text")]
            public string Text { get; set; }

            [JsonProperty(PropertyName = "alias")]
            public string Alias { get; set; }

            [JsonProperty(PropertyName = "emoji")]
            public string Emoji { get; set; }

            [JsonProperty(PropertyName = "avatar")]
            public string Avatar { get; set; }

            [JsonProperty(PropertyName = "attachments")]
            public IEnumerable<Attachment> Attachments { get; set; }

            public class Attachment
            {
                [JsonProperty(PropertyName = "color")]
                public string Color { get; set; }

                [JsonProperty(PropertyName = "text")]
                public string Text { get; set; }

                [JsonProperty(PropertyName = "channel")]
                public string Channel { get; set; }

                [JsonProperty(PropertyName = "ts")]
                public DateTime TimeStamp { get; set; }

                [JsonProperty(PropertyName = "thumb_url")]
                public string ThumbUrl { get; set; }

                [JsonProperty(PropertyName = "message_link")]
                public string MessageLink { get; set; }

                [JsonProperty(PropertyName = "collapsed")]
                public bool Collapsed { get; set; }

                [JsonProperty(PropertyName = "author_name")]
                public string AuthorName { get; set; }

                [JsonProperty(PropertyName = "author_link")]
                public string AuthorLink { get; set; }

                [JsonProperty(PropertyName = "author_icon")]
                public string AuthorIcon { get; set; }

                [JsonProperty(PropertyName = "title")]
                public string Title { get; set; }

                [JsonProperty(PropertyName = "title_link")]
                public string TitleLink { get; set; }

                [JsonProperty(PropertyName = "title_link_download")]
                public bool TitleLinkDownload { get; set; }

                [JsonProperty(PropertyName = "image_url")]
                public string ImageUrl { get; set; }

                [JsonProperty(PropertyName = "audio_url")]
                public string AudioUrl { get; set; }

                [JsonProperty(PropertyName = "video_url")]
                public string VideoUrl { get; set; }

                [JsonProperty(PropertyName = "fields")]
                public IEnumerable<Field> Fields { get; set; }

                public class Field
                {
                    [JsonProperty(PropertyName = "title")]
                    public string Title { get; set; }

                    [JsonProperty(PropertyName = "value")]
                    public string Value { get; set; }
                }
            }
        }

        public class React : Payload
        {
            [JsonProperty(PropertyName = "emoji")]
            public string Emoji { get; set; }

            [JsonProperty(PropertyName = "messageId")]
            public string MessageId { get; set; }

            [JsonProperty(PropertyName = "shouldReact")]
            public bool ShouldReact { get; set; }
        }

        public class ReportMessage : Payload
        {
            [JsonProperty(PropertyName = "messageId")]
            public string MessageId { get; set; }

            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }
        }

        public class SendMessage : Payload
        {
            [JsonProperty(PropertyName = "message")]
            public Message Message { get; set; }
        }

        public class Update : Payload
        {
            [JsonProperty(PropertyName = "msgId")]
            public string MessageId { get; set; }

            [JsonProperty(PropertyName = "text")]
            public string Text { get; set; }
        }

        public class User : Payload
        {
            [JsonProperty(PropertyName = "email")]
            public string Email { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "password")]
            public string Password { get; set; }

            [JsonProperty(PropertyName = "username")]
            public string Username { get; set; }

            [JsonProperty(PropertyName = "active")]
            public bool Active { get; set; }

            [JsonProperty(PropertyName = "roles")]
            public IEnumerable<string> Roles { get; set; }

            [JsonProperty(PropertyName = "joinDefaultChannels")]
            public bool JoinDefaultChannels { get; set; }

            [JsonProperty(PropertyName = "requirePasswordChange")]
            public bool RequirePasswordChange { get; set; }

            [JsonProperty(PropertyName = "sendWelcomeEmail")]
            public bool SendWelcomeEmail { get; set; }

            [JsonProperty(PropertyName = "verified")]
            public bool Verified { get; set; }

            [JsonProperty(PropertyName = "customFields")]
            public string CustomFields { get; set; }
        }

        public class DeleteOwnAccount : Payload
        {
            [JsonProperty(PropertyName = "password")]
            public string Password { get; set; }
        }

        public class ForgotPassword : Payload
        {
            [JsonProperty(PropertyName = "email")]
            public string Email { get; set; }
        }

        public class PersonalAccessToken : Payload
        {
            [JsonProperty(PropertyName = "tokenName")]
            public string TokenName { get; set; }
        }

        public class RegisterUser : Payload
        {
            [JsonProperty(PropertyName = "username")]
            public string Username { get; set; }

            [JsonProperty(PropertyName = "email")]
            public string Email { get; set; }

            [JsonProperty(PropertyName = "pass")]
            public string Password { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "secretURL")]
            public string SecretURL { get; set; }
        }

        public class SetAvatar : Payload
        {
            [JsonProperty(PropertyName = "userId")]
            public string UserId { get; set; }

            [JsonProperty(PropertyName = "avatarUrl")]
            public string AvatarUrl { get; set; }
        }

        public class SetActive : Payload
        {
            [JsonProperty(PropertyName = "userId")]
            public string UserId { get; set; }

            [JsonProperty(PropertyName = "activeStatus")]
            public bool ActiveStatus { get; set; }
        }

        public class UpdateUser : Payload
        {
            [JsonProperty(PropertyName = "userId")]
            public string UserId { get; set; }

            [JsonProperty(PropertyName = "data")]
            public User Data { get; set; }
        }

        public class UpdateOwnBasicInfo : Payload
        {
            [JsonProperty(PropertyName = "data")]
            public OwnBasicInfo Data { get; set; }


            public class OwnBasicInfo
            {
                [JsonProperty(PropertyName = "email")]
                public string Email { get; set; }

                [JsonProperty(PropertyName = "name")]
                public string Name { get; set; }

                [JsonProperty(PropertyName = "username")]
                public string Username { get; set; }

                [JsonProperty(PropertyName = "currentPassword")]
                public string CurrentPassword { get; set; }

                [JsonProperty(PropertyName = "newPassword")]
                public string NewPassword { get; set; }

                [JsonProperty(PropertyName = "customFields")]
                public string customFields { get; set; }
            }
        }
    }
}