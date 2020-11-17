using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MovieMVC.Configuration;
using MovieMVC.Web;

namespace MovieMVC.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MovieMVCDbContextFactory : IDesignTimeDbContextFactory<MovieMVCDbContext>
    {
        public MovieMVCDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MovieMVCDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MovieMVCDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MovieMVCConsts.ConnectionStringName));

            return new MovieMVCDbContext(builder.Options);
        }
    }
}
