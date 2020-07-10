using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PrototipoSistemaFGV.Configuration;

namespace PrototipoSistemaFGV.Web.Host.Startup
{
    [DependsOn(
       typeof(PrototipoSistemaFGVWebCoreModule))]
    public class PrototipoSistemaFGVWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PrototipoSistemaFGVWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototipoSistemaFGVWebHostModule).GetAssembly());
        }
    }
}
