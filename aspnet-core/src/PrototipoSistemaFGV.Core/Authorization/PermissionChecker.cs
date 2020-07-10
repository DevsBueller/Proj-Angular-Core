using Abp.Authorization;
using PrototipoSistemaFGV.Authorization.Roles;
using PrototipoSistemaFGV.Authorization.Users;

namespace PrototipoSistemaFGV.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
