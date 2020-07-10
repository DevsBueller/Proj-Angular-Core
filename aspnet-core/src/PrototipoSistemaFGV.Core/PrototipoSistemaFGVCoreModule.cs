using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using PrototipoSistemaFGV.Authorization.Roles;
using PrototipoSistemaFGV.Authorization.Users;
using PrototipoSistemaFGV.Configuration;
using PrototipoSistemaFGV.Localization;
using PrototipoSistemaFGV.MultiTenancy;
using PrototipoSistemaFGV.Timing;

namespace PrototipoSistemaFGV
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class PrototipoSistemaFGVCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            PrototipoSistemaFGVLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = PrototipoSistemaFGVConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototipoSistemaFGVCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
