using Microsoft.AspNetCore.Builder;

namespace LearningLoop.FeedbackApp.Extensions
{
    public static class ApiExtensions
    {
        public static IApplicationBuilder UseApiLayer(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            return app;
        }
    }
}
