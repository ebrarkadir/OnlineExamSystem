using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OnlineExamSystem.EntityFrameworkCore
{
    public static class OnlineExamSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OnlineExamSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OnlineExamSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
