using Abp.MultiTenancy;
using PrototipoSistemaFGV.Authorization.Users;

namespace PrototipoSistemaFGV.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
