namespace Rocket.Chat.Api.Core.Services
{
    public class Result<TResult>
    {
        public bool Success { get; set; }
        public TResult Content { get; set; }
        public string Error { get; set; }

        public Result()
        {
            Success = false;
            Content = default;
        }

        public Result(TResult content)
        {
            Success = true;
            Content = content;
        }

        public Result(string error)
        {
            Success = false;
            Content = default;
            Error = error;
        }
    }
}