using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PrototipoSistemaFGV.Configuration;
using PrototipoSistemaFGV.EntityFrameworkCore;
using PrototipoSistemaFGV.Migrator.DependencyInjection;

namespace PrototipoSistemaFGV.Migrator
{
    [DependsOn(typeof(PrototipoSistemaFGVEntityFrameworkModule))]
    public class PrototipoSistemaFGVMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PrototipoSistemaFGVMigratorModule(PrototipoSistemaFGVEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PrototipoSistemaFGVMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PrototipoSistemaFGVConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototipoSistemaFGVMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
