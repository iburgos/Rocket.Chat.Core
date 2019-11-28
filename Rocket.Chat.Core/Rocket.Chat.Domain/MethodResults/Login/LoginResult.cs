using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Chat.Domain.MethodResults
{
    public class LoginResult
    {
        [JsonProperty(PropertyName = "status")]
        public LoginStatus Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public LoginData Data { get; set; }
    }

    public class LoginData
    {
        [JsonProperty(PropertyName = "userid")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "authToken")]
        public string AuthToken { get; set; }

        [JsonProperty(PropertyName = "me")]
        public Me Me { get; set; }
    }

    public class Me
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "services")]
        public Services Services { get; set; }

        [JsonProperty(PropertyName = "emails")]
        public IEnumerable<Email> Emails { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "roles")]
        public IEnumerable<string> Roles { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "statusConnection")]
        public string StatusConnection { get; set; }

        [JsonProperty(PropertyName = "utcOffset")]
        public int UtcOffset { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "statusDefault")]
        public string StatusDefault { get; set; }

        [JsonProperty(PropertyName = "settings")]
        public Settings Settings { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "avatarUrl")]
        public string AvatarUrl { get; set; }
    }

    public class Settings
    {
        [JsonProperty(PropertyName = "preferences")]
        public Preferences Preferences { get; set; }   
    }

    public class Preferences
    {

    }

    public class Services
    {
        [JsonProperty(PropertyName = "password")]
        public Password Password { get; set; }
    }

    public class Password
    {
        [JsonProperty(PropertyName = "bcrypt")]
        public string Bcrypt { get; set; }
    }

    public enum LoginStatus
    {
        [JsonProperty(PropertyName = "success")]
        Success
    }
}