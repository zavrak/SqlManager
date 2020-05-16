using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dataplatform.SqlManager.EntityFrameworkCore
{
    public static class SqlManagerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SqlManagerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SqlManagerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
