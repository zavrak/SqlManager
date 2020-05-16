using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dataplatform.SqlManager.Configuration;
using Dataplatform.SqlManager.Web;

namespace Dataplatform.SqlManager.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SqlManagerDbContextFactory : IDesignTimeDbContextFactory<SqlManagerDbContext>
    {
        public SqlManagerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SqlManagerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SqlManagerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SqlManagerConsts.ConnectionStringName));

            return new SqlManagerDbContext(builder.Options);
        }
    }
}
