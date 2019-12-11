using System.Threading.Tasks;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.Payloads;

namespace Rocket.Chat.Api.Core.Services
{
    public interface ICommandsService
    {
        /// <summary>
        /// Get specification of the slash command.
        /// </summary>
        Task<Result<CommandResult>> Get(string command);
        /// <summary>
        /// Lists all available slash commands.
        /// </summary>
        Task<Result<Commands>> List();
        /// <summary>
        /// Execute a slash command in the specified room.
        /// </summary>
        Task<Result<bool>> Run(Payload.RunCommand payload);
    }
}