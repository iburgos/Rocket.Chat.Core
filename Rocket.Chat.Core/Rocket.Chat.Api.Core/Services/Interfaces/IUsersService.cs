using System.Threading.Tasks;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.MethodResults.Users;
using Rocket.Chat.Domain.Payloads;
using Rocket.Chat.Domain.Queries;

namespace Rocket.Chat.Api.Core.Services
{
    internal interface IUsersService
    {
        /// <summary>
        /// Create a new user.
        /// </summary>
        Task<Result<UserResult>> Create(Payload.User payload);
        /// <summary>
        /// Create a user authentication token.
        /// </summary>
        Task<Result<DataResult>> CreateToken(string userId);
        /// <summary>
        /// Deletes an existing user.
        /// </summary>
        Task<Result<bool>> Delete(string userId);
        /// <summary>
        /// Deletes your own user.
        /// </summary>
        Task<Result<bool>> DeleteOwnAccount(string password);
        /// <summary>
        /// Send email to reset your password.
        /// </summary>
        Task<Result<bool>> ForgotPassword(string email);
        /// <summary>
        /// Generate Personal Access Token.
        /// </summary>
        Task<Result<TokenResult>> GeneratePersonalAccessToken(string tokenName);
        /// <summary>
        /// Gets the URL for a user’s avatar.
        /// </summary>
        Task<Result<string>> GetAvatar(string userId);
        /// <summary>
        /// Gets the user’s personal access tokens.
        /// </summary>
        Task<Result<Tokens>> GetPersonalAccessTokens();
        /// <summary>
        /// Gets the user’s preferences.
        /// </summary>
        Task<Result<Preferences>> GetPreferences();
        /// <summary>
        /// Gets the online presence of a user.
        /// </summary>
        Task<Result<PresenceResult>> GetPresence(string userId);
        /// <summary>
        /// Gets a suggestion a new username to user.
        /// </summary>
        Task<Result<StringResult>> GetUsernameSuggestion();
        /// <summary>
        /// Gets a user’s information, limited to the caller’s permissions.
        /// </summary>
        Task<Result<UserResult>> Info(string userId);
        /// <summary>
        /// All of the users and their information, limited to permissions.
        /// </summary>
        Task<Result<Users>> List(UserQuery.List query);
        /// <summary>
        /// Gets all connected users presence.
        /// </summary>
        Task<Result<Users>> Presence(UserQuery.Presence query);
        /// <summary>
        /// Regenerate a user personal access token.
        /// </summary>
        Task<Result<TokenResult>> RegeneratePersonalAccessToken(string tokenName);
        /// <summary>
        /// Register a new user.
        /// </summary>
        Task<Result<UserResult>> Register(Payload.RegisterUser payload);
        /// <summary>
        /// Remove a personal access token.
        /// </summary>
        Task<Result<bool>> RemovePersonalAccessToken(string tokenName);
        /// <summary>
        /// Request users download data.
        /// </summary>
        Task<Result<ExportResult>> RequestDataDownload(bool fullExport = false);
        /// <summary>
        /// Reset a user’s avatar
        /// </summary>
        Task<Result<bool>> ResetAvatar(string userId);
        /// <summary>
        /// Set a user’s active status.
        /// </summary>
        Task<Result<UserResult>> SetActiveStatus(string userId, bool active);
        /// <summary>
        /// Set a user’s avatar
        /// </summary>
        Task<Result<bool>> SetAvatar(Payload.SetAvatar payload);
        /// <summary>
        /// Set a user’s preferences
        /// </summary>
        void SetPreferences();
        /// <summary>
        /// Update an existing user.
        /// </summary>
        Task<Result<UserResult>> Update(Payload.UpdateUser payload);
        /// <summary>
        /// Update basic information of own user.
        /// </summary>
        Task<Result<UserResult>> UpdateOwnBasicInfo(Payload.UpdateOwnBasicInfo payload);
    }
}