using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using PrototipoSistemaFGV.Authorization.Roles;
using PrototipoSistemaFGV.Authorization.Users;
using PrototipoSistemaFGV.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace PrototipoSistemaFGV.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
