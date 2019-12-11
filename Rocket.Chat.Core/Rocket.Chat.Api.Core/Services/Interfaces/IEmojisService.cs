using System;
using System.Threading.Tasks;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.Payloads;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IEmojisService
    {
        /// <summary>
        /// Create new custom emoji.
        /// </summary>
        Task<Result<bool>> Create(Payload.CreateEmoji payload);
        /// <summary>
        /// Delete an existent custom emoji.
        /// </summary>
        Task<Result<bool>> Delete(string emojiId);
        /// <summary>
        /// List all custom emojis on the server.
        /// </summary>
        Task<Result<Emojis>> List(DateTime? updatedSince = null);
        /// <summary>
        /// Update an existent custom emoji.
        /// </summary>
        Task<Result<bool>> Update(Payload.UpdateEmoji payload);
    }
}