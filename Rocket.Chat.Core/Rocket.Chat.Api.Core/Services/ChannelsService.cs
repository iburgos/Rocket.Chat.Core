using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Domain.MethodResults;
using System.Net;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IChannelsService
    {
        Task<Result<ChannelsResult>> ListJoined();
    }

    public class ChannelsService: IChannelsService
    {
        private readonly IRestClientService _restClientService;

        public ChannelsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<ChannelsResult>> ListJoined()
        {
            var response = await _restClientService.Get<ChannelsResult>(ApiHelper.GetUrl("channels.list.joined"));

            Result<ChannelsResult> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<ChannelsResult>(response.Result);
            else
                loginResult = new Result<ChannelsResult>(response.Message);

            return loginResult;
        }
    }
}