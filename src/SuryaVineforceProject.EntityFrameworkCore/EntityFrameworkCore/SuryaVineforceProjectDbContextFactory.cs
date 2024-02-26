using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SuryaVineforceProject.Configuration;
using SuryaVineforceProject.Web;

namespace SuryaVineforceProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SuryaVineforceProjectDbContextFactory : IDesignTimeDbContextFactory<SuryaVineforceProjectDbContext>
    {
        public SuryaVineforceProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SuryaVineforceProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SuryaVineforceProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SuryaVineforceProjectConsts.ConnectionStringName));

            return new SuryaVineforceProjectDbContext(builder.Options);
        }
    }
}
