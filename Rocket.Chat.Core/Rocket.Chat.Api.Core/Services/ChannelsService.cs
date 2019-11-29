using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Domain;
using System.Net;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.Services
{
    public interface IChannelsService
    {
        Task<Result<Channels>> List();
        Task<Result<Channels>> ListJoined();
        Task<Result<Messages>> Messages(string roomId);
        Task<Result<Messages>> History(string roomId);
    }

    public class ChannelsService: IChannelsService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"channels.{endPoint}");

        private readonly IRestClientService _restClientService;

        public ChannelsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<Channels>> List()
        {
            var response = await _restClientService.Get<Channels>(GetUrl("list"));

            Result<Channels> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Channels>(response.Result);
            else
                loginResult = new Result<Channels>(response.Message);

            return loginResult;
        }

        public async Task<Result<Channels>> ListJoined()
        {
            var response = await _restClientService.Get<Channels>(GetUrl("list.joined"));

            Result<Channels> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Channels>(response.Result);
            else
                loginResult = new Result<Channels>(response.Message);

            return loginResult;
        }

        public async Task<Result<Messages>> Messages(string roomId)
        {
            string route = $"{GetUrl("messages")}?roomId={roomId}";
            var response = await _restClientService.Get<Messages>(route);

            Result<Messages> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Messages>(response.Result);
            else
                loginResult = new Result<Messages>(response.Message);

            return loginResult;
        }

        public async Task<Result<Messages>> History(string roomId)
        {
            string route = $"{GetUrl("history")}?roomId={roomId}";
            var response = await _restClientService.Get<Messages>(route);

            Result<Messages> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<Messages>(response.Result);
            else
                loginResult = new Result<Messages>(response.Message);

            return loginResult;
        }
    }
}