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

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("t")]
        public string Type { get; set; }

        [JsonProperty("rid")]
        public string RoomId { get; set; }

        [JsonProperty("ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("msg")]
        public string Content { get; set; }

        [JsonProperty("u")]
        public User Owner { get; set; }

        [JsonProperty("groupable")]
        public bool IsGroupable { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("mentions")]
        public IEnumerable<User> Mentions { get; set; }

        [JsonProperty("channels")]
        public IEnumerable<Channel> Channels { get; set; }

        [JsonProperty("attachments"), NotNull]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty("starred"), NotNull]
        public List<User> Starred { get; set; }

        [JsonProperty("editedBy")]
        public User EditedBy { get; set; }

        [JsonProperty("editedAt")]
        public DateTime? EditedAt { get; set; }

        [JsonConverter(typeof(RocketReactionConverter))]
        public List<Reaction> Reactions { get; set; }

        [JsonProperty("urls")]
        public List<Url> Urls { get; set; }

        [JsonProperty("parseUrls")]
        public bool ParseUrls { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("bot")]
        public Bot Bot { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        //Check this properties

        [JsonProperty("pinned")]
        public bool IsPinned { get; set; }

        [JsonProperty("pinnedAt")]
        public DateTime? PinnedAt { get; set; }

        [JsonProperty("pinnedBy")]
        public User PinnedBy { get; set; }
    }
}