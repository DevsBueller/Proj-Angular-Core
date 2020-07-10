using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PrototipoSistemaFGV.Authorization;

namespace PrototipoSistemaFGV
{
    [DependsOn(
        typeof(PrototipoSistemaFGVCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PrototipoSistemaFGVApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PrototipoSistemaFGVAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PrototipoSistemaFGVApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
