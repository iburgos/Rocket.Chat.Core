using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Domain.MethodResults;
using System.Net;

namespace Rocket.Chat.Api.Core.Services.Helpers
{
    public class ServiceHelper
    {
        public static Result<TResult> MapResponse<TResult>(ApiResponse<TResult> response)
        {
            Result<TResult> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<TResult>(response.Result);
            else
                loginResult = new ErrorResult<TResult>(response.Message);

            return loginResult;
        }

        public static Result<bool> MapBoolResponse(ApiResponse<CallResult> response)
        {
            Result<bool> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = response.Result.Success ? new Result<bool>(true) : new ErrorResult<bool>(response.Result.Error);
            else
                loginResult = new ErrorResult<bool>(response.Message);

            return loginResult;
        }
    }
}