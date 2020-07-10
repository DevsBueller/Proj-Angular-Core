using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PrototipoSistemaFGV.EntityFrameworkCore;
using PrototipoSistemaFGV.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PrototipoSistemaFGV.Web.Tests
{
    [DependsOn(
        typeof(PrototipoSistemaFGVWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PrototipoSistemaFGVWebTestModule : AbpModule
    {
        public PrototipoSistemaFGVWebTestModule(PrototipoSistemaFGVEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototipoSistemaFGVWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PrototipoSistemaFGVWebMvcModule).Assembly);
        }
    }
}