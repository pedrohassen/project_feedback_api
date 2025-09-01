using LearningLoop.FeedbackApp.Extensions;

namespace LearningLoop.FeedbackApp.DI
{
    public static class RegistrationDependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories();
            services.AddSwaggerConfiguration();
            services.AddJwtAuthentication(configuration);
            services.AddAutoMapper(config => config.AddMaps(typeof(Program).Assembly));
            services.AddCorsConfiguration();
            return services;
        }
    }
}
