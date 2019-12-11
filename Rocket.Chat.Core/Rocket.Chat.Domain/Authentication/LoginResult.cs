using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Chat.Domain.Authentication
{
    public class LoginResult
    {
        [JsonProperty("status")]
        public LoginStatus Status { get; set; }

        [JsonProperty("data")]
        public LoginData Data { get; set; }
    }

    public class LoginData
    {
        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("me")]
        public Me Me { get; set; }
    }

    public class Me
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("services")]
        public Services Services { get; set; }

        [JsonProperty("emails")]
        public IEnumerable<Email> Emails { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("roles")]
        public IEnumerable<string> Roles { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("statusConnection")]
        public string StatusConnection { get; set; }

        [JsonProperty("utcOffset")]
        public int UtcOffset { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("statusDefault")]
        public string StatusDefault { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }
    }

    public class Settings
    {
        [JsonProperty("preferences")]
        public Preferences Preferences { get; set; }   
    }

    public class Preferences
    {

    }

    public class Services
    {
        [JsonProperty("password")]
        public Password Password { get; set; }
    }

    public class Password
    {
        [JsonProperty("bcrypt")]
        public string Bcrypt { get; set; }
    }

    public enum LoginStatus
    {
        [JsonProperty("success")]
        Success
    }
}