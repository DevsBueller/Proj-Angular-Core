using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PrototipoSistemaFGV.EntityFrameworkCore
{
    public static class PrototipoSistemaFGVDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PrototipoSistemaFGVDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PrototipoSistemaFGVDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
