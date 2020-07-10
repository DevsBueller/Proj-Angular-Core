using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using PrototipoSistemaFGV.EntityFrameworkCore.Seed;

namespace PrototipoSistemaFGV.EntityFrameworkCore
{
    [DependsOn(
        typeof(PrototipoSistemaFGVCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class PrototipoSistemaFGVEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<PrototipoSistemaFGVDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        PrototipoSistemaFGVDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        PrototipoSistemaFGVDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototipoSistemaFGVEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
