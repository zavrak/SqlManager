using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dataplatform.SqlManager.Authorization.Roles;
using Dataplatform.SqlManager.Authorization.Users;
using Dataplatform.SqlManager.MultiTenancy;

namespace Dataplatform.SqlManager.EntityFrameworkCore
{
    public class SqlManagerDbContext : AbpZeroDbContext<Tenant, Role, User, SqlManagerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<ScriptDocument.ScriptDocument> ScriptDocuments { get; set; }

        public SqlManagerDbContext(DbContextOptions<SqlManagerDbContext> options)
            : base(options)
        {
        }
    }
}
