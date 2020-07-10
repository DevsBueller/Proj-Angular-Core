using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PrototipoSistemaFGV.Configuration;
using PrototipoSistemaFGV.Web;

namespace PrototipoSistemaFGV.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PrototipoSistemaFGVDbContextFactory : IDesignTimeDbContextFactory<PrototipoSistemaFGVDbContext>
    {
        public PrototipoSistemaFGVDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PrototipoSistemaFGVDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PrototipoSistemaFGVDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PrototipoSistemaFGVConsts.ConnectionStringName));

            return new PrototipoSistemaFGVDbContext(builder.Options);
        }
    }
}
