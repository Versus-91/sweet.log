using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace sweet.log.EntityFrameworkCore
{
    public static class logDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<logDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<logDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
