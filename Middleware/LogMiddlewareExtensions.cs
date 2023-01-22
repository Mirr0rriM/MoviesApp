using Microsoft.AspNetCore.Builder;

namespace MoviesApp.Middleware
{
    public static class LogMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestLog(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}