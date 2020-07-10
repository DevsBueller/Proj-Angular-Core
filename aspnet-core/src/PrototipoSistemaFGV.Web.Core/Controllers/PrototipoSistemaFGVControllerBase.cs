using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PrototipoSistemaFGV.Controllers
{
    public abstract class PrototipoSistemaFGVControllerBase: AbpController
    {
        protected PrototipoSistemaFGVControllerBase()
        {
            LocalizationSourceName = PrototipoSistemaFGVConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
