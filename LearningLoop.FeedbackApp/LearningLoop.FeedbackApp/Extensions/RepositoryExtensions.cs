namespace LearningLoop.FeedbackApp.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<Repositories.DbConnectionFactory>();
            return services;
        }
    }
}
