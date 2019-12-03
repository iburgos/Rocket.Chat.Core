using RestSharp;
using Rocket.Chat.Api.Core.Services;
using Serilog;
using System;
using System.Threading.Tasks;

namespace Rocket.Chat.Api.Core.RestHelpers
{
    public interface IRestClientService
    {
        Task<ApiResponse<TResult>> Post<TResult>(string route, object body);
        Task<ApiResponse<TResult>> Get<TResult>(string route);
        Task<ApiResponse<TResult>> Put<TResult>(string route, object body);
        Task<ApiResponse<TResult>> Delete<TResult>(string route, object body = null);
        Task<ApiResponse<byte[]>> GetFile(string route);
        Task<ApiResponse<byte[]>> GetFile(string route, object body);
    }

    public class RestClientService : IRestClientService
    {
        public ILogger Logger = Log.Logger;
        private readonly IAuthHelper _authHelper;
        private readonly IRestClient _restClient;
        private readonly IJsonConvertHelper _jsonConvertHelper;

        public RestClientService(
            IAuthHelper authHelper,
            IRestClient restClient,
            IJsonConvertHelper jsonConvertHelper)
        {
            _authHelper = authHelper;
            _restClient = restClient;
            _jsonConvertHelper = jsonConvertHelper;
        }

        public async Task<ApiResponse<TResult>> Post<TResult>(string route, object body)
        {
            try
            {
                RestRequest request = CreateRequest(route, Method.POST, body);

                IRestResponse response = await _restClient.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    var responseContent = _jsonConvertHelper.Deserialize<TResult>(response.Content);
                    return new ApiResponse<TResult>(response.StatusCode, responseContent);
                }
                return new ApiResponse<TResult>(response.StatusCode, response.ResponseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Post call to API threw an exception");
                return new ApiResponse<TResult>(ex.Message, ex.StackTrace);
            }
        }

        public async Task<ApiResponse<TResult>> Get<TResult>(string route)
        {
            try
            {
                RestRequest request = CreateRequest(route, Method.GET);

                IRestResponse response = await _restClient.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    var responseContent = _jsonConvertHelper.Deserialize<TResult>(response.Content);
                    return new ApiResponse<TResult>(response.StatusCode, responseContent);
                }
                return new ApiResponse<TResult>(response.StatusCode, response.ResponseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Get call to API threw an exception");
                return new ApiResponse<TResult>(ex.Message, ex.StackTrace);
            }
        }

        public async Task<ApiResponse<TResult>> Put<TResult>(string route, object body)
        {
            try
            {
                RestRequest request = CreateRequest(route, Method.PUT, body);

                IRestResponse response = await _restClient.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    var responseContent = _jsonConvertHelper.Deserialize<TResult>(response.Content);
                    return new ApiResponse<TResult>(response.StatusCode, responseContent);
                }
                return new ApiResponse<TResult>(response.StatusCode, response.ResponseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Put call to API threw an exception");
                return new ApiResponse<TResult>(ex.Message, ex.StackTrace);
            }
        }

        public async Task<ApiResponse<TResult>> Delete<TResult>(string route, object body = null)
        {
            try
            {
                RestRequest request = CreateRequest(route, Method.DELETE, body);

                IRestResponse response = await _restClient.ExecuteTaskAsync(request);
                if (response.IsSuccessful)
                {
                    var responseContent = _jsonConvertHelper.Deserialize<TResult>(response.Content);
                    return new ApiResponse<TResult>(response.StatusCode, responseContent);
                }
                return new ApiResponse<TResult>(response.StatusCode, response.ResponseStatus);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Delete call to API threw an exception");
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
                request.AddJsonBody(body);
            }

            return request;
        }
    }
}
