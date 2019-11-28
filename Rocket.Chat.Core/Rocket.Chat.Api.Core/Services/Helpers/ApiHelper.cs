namespace Rocket.Chat.Api.Core.Services
{
    public class ApiHelper
    {
        private const string API_VERSION = "api/v1";

        public static string GetUrl(string endPoint) => $"{API_VERSION}/{endPoint}";
    }
}
