using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain.Payloads
{
    public class Payload
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        public class AddAll : Payload
        {
            [JsonProperty("activeUsersOnly")]
            public bool ActiveUsersOnly { get; set; }
        }

        public class UserAction : Payload
        {
            [JsonProperty("userId")]
            public string UserId { get; set; }
        }

        public class Create : Payload
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("members")]
            public IEnumerable<string> Members { get; set; }

            [JsonProperty("readOnly")]
            public bool ReadOnly { get; set; }
        }

        public class Join : Payload
        {
            [JsonProperty("joinCode")]
            public string JoinCode { get; set; }
        }

        public class Rename : Payload
        {
            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class SetAnnouncement : Payload
        {
            [JsonProperty("announcement")]
            public string Announcement { get; set; }
        }

        public class SetCustomFields : Payload
        {
            [JsonProperty("roomName")]
            public string RoomName { get; set; }

            [JsonProperty("customFields")]
            public string CustomFields { get; set; }
        }

        public class SetDescription : Payload
        {
            [JsonProperty("description")]
            public string Description { get; set; }
        }

        public class SetJoinCode : Payload
        {
            [JsonProperty("joinCode")]
            public string JoinCode { get; set; }
        }

        public class SetPurpose : Payload
        {
            [JsonProperty("purpose")]
            public string Purpose { get; set; }
        }

        public class SetReadOnly : Payload
        {
            [JsonProperty("readOnly")]
            public bool ReadOnly { get; set; }
        }

        public class SetTopic : Payload
        {
            [JsonProperty("topic")]
            public string Topic { get; set; }
        }

        public class SetType : Payload
        {
            /// <summary>
            /// The type of room this channel should be, either c or p.
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; }
        }

        public class DeleteMessage: Payload
        {
            [JsonProperty("messageId")]
            public string MessageId { get; set; }

            [JsonProperty("asUser")]
            public bool AsUser { get; set; }
        }

        public class FollowMessage : Payload
        {
            [JsonProperty("mid")]
            public string MessageId { get; set; }
        }

        public class PinMessage : Payload
        {
            [JsonProperty("messageId")]
            public string MessageId { get; set; }
        }

        public class StarMessage : Payload
        {
            [JsonProperty("messageId")]
            public string MessageId { get; set; }
        }

        public class PostMessage : Payload
        {
            [JsonProperty("channel")]
            public string Channel { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("alias")]
            public string Alias { get; set; }

            [JsonProperty("emoji")]
            public string Emoji { get; set; }

            [JsonProperty("avatar")]
            public string Avatar { get; set; }

            [JsonProperty("attachments")]
            public IEnumerable<Attachment> Attachments { get; set; }

            public class Attachment
            {
                [JsonProperty("color")]
                public string Color { get; set; }

                [JsonProperty("text")]
                public string Text { get; set; }

                [JsonProperty("channel")]
                public string Channel { get; set; }

                [JsonProperty("ts")]
                public DateTime TimeStamp { get; set; }

                [JsonProperty("thumb_url")]
                public string ThumbUrl { get; set; }

                [JsonProperty("message_link")]
                public string MessageLink { get; set; }

                [JsonProperty("collapsed")]
                public bool Collapsed { get; set; }

                [JsonProperty("author_name")]
                public string AuthorName { get; set; }

                [JsonProperty("author_link")]
                public string AuthorLink { get; set; }

                [JsonProperty("author_icon")]
                public string AuthorIcon { get; set; }

                [JsonProperty("title")]
                public string Title { get; set; }

                [JsonProperty("title_link")]
                public string TitleLink { get; set; }

                [JsonProperty("title_link_download")]
                public bool TitleLinkDownload { get; set; }

                [JsonProperty("image_url")]
                public string ImageUrl { get; set; }

                [JsonProperty("audio_url")]
                public string AudioUrl { get; set; }

                [JsonProperty("video_url")]
                public string VideoUrl { get; set; }

                [JsonProperty("fields")]
                public IEnumerable<Field> Fields { get; set; }

                public class Field
                {
                    [JsonProperty("title")]
                    public string Title { get; set; }

                    [JsonProperty("value")]
                    public string Value { get; set; }
                }
            }
        }

        public class React : Payload
        {
            [JsonProperty("emoji")]
            public string Emoji { get; set; }

            [JsonProperty("messageId")]
            public string MessageId { get; set; }

            [JsonProperty("shouldReact")]
            public bool ShouldReact { get; set; }
        }

        public class ReportMessage : Payload
        {
            [JsonProperty("messageId")]
            public string MessageId { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }
        }

        public class SendMessage : Payload
        {
            [JsonProperty("message")]
            public Message Message { get; set; }
        }

        public class Update : Payload
        {
            [JsonProperty("msgId")]
            public string MessageId { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }
        }

        public class User : Payload
        {
            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("active")]
            public bool Active { get; set; }

            [JsonProperty("roles")]
            public IEnumerable<string> Roles { get; set; }

            [JsonProperty("joinDefaultChannels")]
            public bool JoinDefaultChannels { get; set; }

            [JsonProperty("requirePasswordChange")]
            public bool RequirePasswordChange { get; set; }

            [JsonProperty("sendWelcomeEmail")]
            public bool SendWelcomeEmail { get; set; }

            [JsonProperty("verified")]
            public bool Verified { get; set; }

            [JsonProperty("customFields")]
            public string CustomFields { get; set; }
        }

        public class DeleteOwnAccount : Payload
        {
            [JsonProperty("password")]
            public string Password { get; set; }
        }

        public class ForgotPassword : Payload
        {
            [JsonProperty("email")]
            public string Email { get; set; }
        }

        public class PersonalAccessToken : Payload
        {
            [JsonProperty("tokenName")]
            public string TokenName { get; set; }
        }

        public class RegisterUser : Payload
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("pass")]
            public string Password { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("secretURL")]
            public string SecretURL { get; set; }
        }

        public class SetAvatar : Payload
        {
            [JsonProperty("userId")]
            public string UserId { get; set; }

            [JsonProperty("avatarUrl")]
            public string AvatarUrl { get; set; }
        }

        public class SetActive : Payload
        {
            [JsonProperty("userId")]
            public string UserId { get; set; }

            [JsonProperty("activeStatus")]
            public bool ActiveStatus { get; set; }
        }

        public class UpdateUser : Payload
        {
            [JsonProperty("userId")]
            public string UserId { get; set; }

            [JsonProperty("data")]
            public User Data { get; set; }
        }

        public class UpdateOwnBasicInfo : Payload
        {
            [JsonProperty("data")]
            public OwnBasicInfo Data { get; set; }


            public class OwnBasicInfo
            {
                [JsonProperty("email")]
                public string Email { get; set; }

                [JsonProperty("name")]
                public string Name { get; set; }

                [JsonProperty("username")]
                public string Username { get; set; }

                [JsonProperty("currentPassword")]
                public string CurrentPassword { get; set; }

                [JsonProperty("newPassword")]
                public string NewPassword { get; set; }

                [JsonProperty("customFields")]
                public string customFields { get; set; }
            }
        }

        public class CleanHistory : Payload
        {
            [JsonProperty("latest")]
            public DateTime Latest { get; set; }

            [JsonProperty("oldest")]
            public DateTime Oldest { get; set; }

            [JsonProperty("inclusive")]
            public bool Inclusive { get; set; }

            [JsonProperty("excludePinned")]
            public bool ExcludePinned { get; set; }

            [JsonProperty("filesOnly")]
            public bool FilesOnly { get; set; }

            [JsonProperty("users")]
            public IEnumerable<string> Users { get; set; }
        }

        public class CreateDiscussion : Payload
        {
            [JsonProperty("prid")]
            public string ParentRoomId { get; set; }

            [JsonProperty("t_name")]
            public string DiscussionName { get; set; }

            [JsonProperty("users")]
            public IEnumerable<string> Users { get; set; }

            [JsonProperty("pmid")]
            public string ParentMessageId { get; set; }

            [JsonProperty("excludePinned")]
            public bool ExcludePinned { get; set; }

            [JsonProperty("reply")]
            public string Reply { get; set; }
        }

        public class FavoriteRoom : Payload
        {
            [JsonProperty("favorite")]
            public bool Favorite { get; set; }
        }

        public class Notification : Payload
        {
            [JsonProperty("notifications")]
            public Options Notifications { get; set; }

            public class Options
            {
                [JsonProperty("desktopNotifications")]
                public string DesktopNotifications { get; set; }

                [JsonProperty("disableNotifications")]
                public string DisableNotifications { get; set; }

                [JsonProperty("emailNotifications")]
                public string EmailNotifications { get; set; }

                [JsonProperty("audioNotificationValue")]
                public string AudioNotificationValue { get; set; }

                [JsonProperty("desktopNotificationDuration")]
                public string DesktopNotificationDuration { get; set; }

                [JsonProperty("audioNotifications")]
                public string AudioNotifications { get; set; }

                [JsonProperty("unreadAlert")]
                public string UnreadAlert { get; set; }

                [JsonProperty("hideUnreadStatus")]
                public string HideUnreadStatus { get; set; }

                [JsonProperty("mobilePushNotifications")]
                public string MobilePushNotifications { get; set; }
            }
        }
    }
}