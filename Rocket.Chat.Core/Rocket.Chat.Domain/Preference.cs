using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Preference
    {
        [JsonProperty(PropertyName = "newRoomNotification")]
        public string NewRoomNotification { get; set; }

        [JsonProperty(PropertyName = "newMessageNotification")]
        public string NewMessageNotification { get; set; }

        [JsonProperty(PropertyName = "muteFocusedConversations")]
        public bool MuteFocusedConversations { get; set; }

        [JsonProperty(PropertyName = "useEmojis")]
        public bool UseEmojis { get; set; }

        [JsonProperty(PropertyName = "convertAsciiEmoji")]
        public bool ConvertAsciiEmoji { get; set; }

        [JsonProperty(PropertyName = "saveMobileBandwidth")]
        public bool SaveMobileBandwidth { get; set; }

        [JsonProperty(PropertyName = "collapseMediaByDefault")]
        public bool CollapseMediaByDefault { get; set; }

        [JsonProperty(PropertyName = "autoImageLoad")]
        public bool AutoImageLoad { get; set; }

        [JsonProperty(PropertyName = "emailNotificationMode")]
        public string EmailNotificationMode { get; set; }

        [JsonProperty(PropertyName = "roomsListExhibitionMode")]
        public string RoomsListExhibitionMode { get; set; }

        [JsonProperty(PropertyName = "unreadAlert")]
        public bool UnreadAlert { get; set; }

        [JsonProperty(PropertyName = "notificationsSoundVolume")]
        public int NotificationsSoundVolume { get; set; }

        [JsonProperty(PropertyName = "desktopNotifications")]
        public string DesktopNotifications { get; set; }

        [JsonProperty(PropertyName = "mobileNotifications")]
        public string MobileNotifications { get; set; }

        [JsonProperty(PropertyName = "enableAutoAway")]
        public bool EnableAutoAway { get; set; }

        [JsonProperty(PropertyName = "highlights")]
        public IEnumerable<string> Highlights { get; set; }

        [JsonProperty(PropertyName = "desktopNotificationDuration")]
        public int DesktopNotificationDuration { get; set; }

        [JsonProperty(PropertyName = "viewMode")]
        public int ViewMode { get; set; }

        [JsonProperty(PropertyName = "hideUsernames")]
        public bool HideUsernames { get; set; }

        [JsonProperty(PropertyName = "hideRoles")]
        public bool HideRoles { get; set; }

        [JsonProperty(PropertyName = "hideAvatars")]
        public bool HideAvatars { get; set; }

        [JsonProperty(PropertyName = "hideFlexTab")]
        public bool HideFlexTab { get; set; }

        [JsonProperty(PropertyName = "sendOnEnter")]
        public string SendOnEnter { get; set; }

        [JsonProperty(PropertyName = "roomCounterSidebar")]
        public bool RoomCounterSidebar { get; set; }
    }
}