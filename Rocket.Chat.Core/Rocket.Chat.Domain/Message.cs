namespace Rocket.Chat.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using Newtonsoft.Json;

    using Rocket.Chat.Domain.JsonConverters;

    public class Message
    {
        public Message()
        {
            Mentions = new List<User>();
            Channels = new List<Channel>();
            Attachments = new List<Attachment>();
            Starred = new List<User>();
            Reactions = new List<Reaction>();
        }

        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "t")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "rid")]
        public string RoomId { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "msg")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "u")]
        public User User { get; set; }

        [JsonProperty(PropertyName = "groupable")]
        public bool IsGroupable { get; set; }

        [JsonProperty(PropertyName = "_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "mentions")]
        public IEnumerable<User> Mentions { get; set; }

        [JsonProperty(PropertyName = "channels")]
        public IEnumerable<Channel> Channels { get; set; }

        [JsonProperty(PropertyName = "attachments"), NotNull]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty(PropertyName = "starred"), NotNull]
        public List<User> Starred { get; set; }

        [JsonProperty(PropertyName = "editedBy")]
        public User EditedBy { get; set; }

        [JsonProperty(PropertyName = "editedAt")]
        public DateTime? EditedAt { get; set; }

        [JsonConverter(typeof(RocketReactionConverter))]
        public List<Reaction> Reactions { get; set; }

        [JsonProperty(PropertyName = "urls")]
        public List<Url> Urls { get; set; }

        [JsonProperty(PropertyName = "parseUrls")]
        public bool ParseUrls { get; set; }

        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }

        [JsonProperty(PropertyName = "bot")]
        public Bot Bot { get; set; }

        [JsonProperty(PropertyName = "emoji")]
        public string Emoji { get; set; }

        [JsonProperty(PropertyName = "avatar")]
        public string Avatar { get; set; }

        //Check this properties

        [JsonProperty(PropertyName = "pinned")]
        public bool IsPinned { get; set; }

        [JsonProperty(PropertyName = "pinnedAt")]
        public DateTime? PinnedAt { get; set; }

        [JsonProperty(PropertyName = "pinnedBy")]
        public User PinnedBy { get; set; }
    }
}