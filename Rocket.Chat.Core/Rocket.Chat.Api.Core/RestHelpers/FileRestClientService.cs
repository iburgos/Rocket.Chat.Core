using RestSharp;
using Rocket.Chat.Api.Core.Services;
using Serilog;
using System;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.RestHelpers
{
    public interface IFileRestClientService
    {
        Task<ApiResponse<byte[]>> GetFile(string route);
        Task<ApiResponse<byte[]>> GetFile(string route, object body);
        Task<ApiResponse<TResult>> CreateEmoji<TResult>(string route, string name, string aliases, byte[] emoji);
        Task<ApiResponse<TResult>> UpdateEmoji<TResult>(string route, string emojiId, string name, string aliases, byte[] emoji);
    }

    public class FileRestClientService : IFileRestClientService
    {
        public ILogger Logger = Log.Logger;
        private readonly IAuthHelper _authHelper;
        private readonly IRestClient _restClient;
        private readonly IJsonSerializer _jsonSerializer;

        public FileRestClientService(
            IAuthHelper authHelper,
            IRestClient restClient,
            IJsonSerializer jsonSerializer)
        {
            _authHelper = authHelper;
            _restClient = restClient;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<ApiResponse<TResult>> CreateEmoji<TResult>(string route, string name, string aliases, byte[] emoji)
        {
            try
            {
                RestRequest request = CreateEmojiRequest(route, name, aliases, emoji);

                IRestResponse response = await _restClient.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    var responseContent = _jsonSerializer.Deserialize<TResult>(response.Content);
                    return new ApiResponse<TResult>(response.StatusCode, responseContent);
                }
                return new ApiResponse<TResult>(response.StatusCode, response.ResponseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "CreateEmoji call to API threw an exception");
                return new ApiResponse<TResult>(ex.Message, ex.StackTrace);
            }
        }

        public async Task<ApiResponse<TResult>> UpdateEmoji<TResult>(string route, string emojiId, string name, string aliases, byte[] emoji)
        {
            try
            {
                RestRequest request = CreateEmojiRequest(route, name, aliases, emoji);
                request.AddParameter("_id", emojiId, ParameterType.RequestBody);

                IRestResponse response = await _restClient.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    var responseContent = _jsonSerializer.Deserialize<TResult>(response.Content);
                    return new ApiResponse<TResult>(response.StatusCode, responseContent);
                }
                return new ApiResponse<TResult>(response.StatusCode, response.ResponseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "UpdateEmoji call to API threw an exception");
                return new ApiResponse<TResult>(ex.Message, ex.StackTrace);
            }
        }

        public async Task<ApiResponse<byte[]>> GetFile(string route)
        {
            try
            {
                var request = new RestRequest(route, Method.GET);
                IRestResponse response = await _restClient.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    return new ApiResponse<byte[]>(response.StatusCode, response.RawBytes);
                }
                return new ApiResponse<byte[]>(response.StatusCode, response.ResponseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "GetFile GET call to API threw an exception");
                return new ApiResponse<byte[]>(ex.Message, ex.StackTrace);
            }
        }

        public async Task<ApiResponse<byte[]>> GetFile(string route, object body)
        {
            try
            {
                var request = CreateRequest(route, Method.POST, body);
                IRestResponse response = await _restClient.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    return new ApiResponse<byte[]>(response.StatusCode, response.RawBytes);
                }
                return new ApiResponse<byte[]>(response.StatusCode, response.ResponseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "GetFile POST call to API threw an exception");
                return new ApiResponse<byte[]>(ex.Message, ex.StackTrace);
            }
        }

        private RestRequest CreateEmojiRequest(string route, string name, string aliases, byte[] emoji)
        {
            var request = new RestRequest(route, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AlwaysMultipartFormData = true;

            request.AddParameter("emoji", emoji, ParameterType.RequestBody);
            request.AddParameter("name", name, ParameterType.RequestBody);
            request.AddParameter("aliases", aliases, ParameterType.RequestBody);

            if (_authHelper.IsAuthorized)
            {
                request.AddHeader("X-User-Id", _authHelper.UserId);
                request.AddHeader("X-Auth-Token", _authHelper.AuthToken);
            }

            return request;
        }

        private RestRequest CreateRequest(string route, Method method, object body = null)
        {
            var request = new RestRequest(route, method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            if (_authHelper.IsAuthorized)
            {
                request.AddHeader("X-User-Id", _authHelper.UserId);
                request.AddHeader("X-Auth-Token", _authHelper.AuthToken);
            }

            if (body != null)
            {
                request.AddJsonBody(_jsonSerializer.Serialize(body));
            }

            return request;
        }
    }
}