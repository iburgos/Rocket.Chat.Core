using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services.Helpers;
using Rocket.Chat.Domain;
using Rocket.Chat.Domain.MethodResults;
using Rocket.Chat.Domain.Payloads;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core.Services
{
    internal class CommandsService : ICommandsService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"commands.{endPoint}");

        private readonly IRestClientService _restClientService;

        public CommandsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<CommandResult>> Get(string command)
        {
            string route = $"{GetUrl("get")}?command={command}";
            var response = await _restClientService.Get<CommandResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Commands>> List()
        {
            var response = await _restClientService.Get<Commands>(GetUrl("list"));
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Run(Payload.RunCommand payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("run"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }
    }
}