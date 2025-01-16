

namespace WTC_CMS_BE.API.Middlewares
{
    public class CustomLoggingMiddleware : ICustomLoggingMiddleware
    {
        public async Task LogDummyExceptions(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface ICustomLoggingMiddleware
    {
        public Task LogDummyExceptions(string message);
    }
}
