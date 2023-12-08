using Microsoft.EntityFrameworkCore;
using BookWiseBusLogic.Context.DBModel;
using dotenv.net;

namespace BookWiseBusLogic.Context
{
    public class BookWiseDBContext : DbContext
    {
        public DbSet<DBUser> User { get; set; }
        public DbSet<DBBook> Book { get; set; }
        public DbSet<DBStudent> Student { get; set; }
        public DbSet<DBFaculty> Faculty { get; set; }
        public DbSet<DBBookTransaction> BookTransaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { "../.env" }));

            string host = Environment.GetEnvironmentVariable("PG_HOST");
            string database = Environment.GetEnvironmentVariable("PG_NAME");
            string port = Environment.GetEnvironmentVariable("PG_PORT");
            string user = Environment.GetEnvironmentVariable("PG_USER");
            string password = Environment.GetEnvironmentVariable("PG_PASSWORD");

            optionsBuilder.UseNpgsql(
                $"Host={host};Port={port};Database={database};Username={user};Password={password}"
            );
        }
    }
}
