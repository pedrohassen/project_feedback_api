using Npgsql;

namespace LearningLoop.FeedbackApp.Repositories
{
    public sealed class DbConnectionFactory
    {
        private readonly string _cs;
        public DbConnectionFactory(IConfiguration cfg) => _cs = cfg.GetConnectionString("PostgresConnection")!;
        public NpgsqlConnection Create() => new NpgsqlConnection(_cs);
    }
}
