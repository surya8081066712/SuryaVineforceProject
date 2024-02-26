using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SuryaVineforceProject.EntityFrameworkCore
{
    public static class SuryaVineforceProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SuryaVineforceProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SuryaVineforceProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
