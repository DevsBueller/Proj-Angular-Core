using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace PrototipoSistemaFGV.Authorization
{
    public class PrototipoSistemaFGVAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_BaseCalculos, L("BaseCalculos"), multiTenancySides: MultiTenancySides.Tenant);
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, PrototipoSistemaFGVConsts.LocalizationSourceName);
        }
    }
}
