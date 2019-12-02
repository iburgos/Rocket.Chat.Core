using Rocket.Chat.Api.Core.RestHelpers;
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
                loginResult = new Result<TResult>(response.Message);

            return loginResult;
        }
    }
}