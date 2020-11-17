using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MovieMVC.EntityFrameworkCore
{
    public static class MovieMVCDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MovieMVCDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MovieMVCDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
