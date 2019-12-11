using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Preference
    {
        [JsonProperty("newRoomNotification")]
        public string NewRoomNotification { get; set; }

        [JsonProperty("newMessageNotification")]
        public string NewMessageNotification { get; set; }

        [JsonProperty("muteFocusedConversations")]
        public bool MuteFocusedConversations { get; set; }

        [JsonProperty("useEmojis")]
        public bool UseEmojis { get; set; }

        [JsonProperty("convertAsciiEmoji")]
        public bool ConvertAsciiEmoji { get; set; }

        [JsonProperty("saveMobileBandwidth")]
        public bool SaveMobileBandwidth { get; set; }

        [JsonProperty("collapseMediaByDefault")]
        public bool CollapseMediaByDefault { get; set; }

        [JsonProperty("autoImageLoad")]
        public bool AutoImageLoad { get; set; }

        [JsonProperty("emailNotificationMode")]
        public string EmailNotificationMode { get; set; }

        [JsonProperty("roomsListExhibitionMode")]
        public string RoomsListExhibitionMode { get; set; }

        [JsonProperty("unreadAlert")]
        public bool UnreadAlert { get; set; }

        [JsonProperty("notificationsSoundVolume")]
        public int NotificationsSoundVolume { get; set; }

        [JsonProperty("desktopNotifications")]
        public string DesktopNotifications { get; set; }

        [JsonProperty("mobileNotifications")]
        public string MobileNotifications { get; set; }

        [JsonProperty("enableAutoAway")]
        public bool EnableAutoAway { get; set; }

        [JsonProperty("highlights")]
        public IEnumerable<string> Highlights { get; set; }

        [JsonProperty("desktopNotificationDuration")]
        public int DesktopNotificationDuration { get; set; }

        [JsonProperty("viewMode")]
        public int ViewMode { get; set; }

        [JsonProperty("hideUsernames")]
        public bool HideUsernames { get; set; }

        [JsonProperty("hideRoles")]
        public bool HideRoles { get; set; }

        [JsonProperty("hideAvatars")]
        public bool HideAvatars { get; set; }

        [JsonProperty("hideFlexTab")]
        public bool HideFlexTab { get; set; }

        [JsonProperty("sendOnEnter")]
        public string SendOnEnter { get; set; }

        [JsonProperty("roomCounterSidebar")]
        public bool RoomCounterSidebar { get; set; }
    }
}