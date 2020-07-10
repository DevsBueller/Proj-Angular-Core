using System.Threading.Tasks;
using Abp.Application.Services;
using PrototipoSistemaFGV.Authorization.Accounts.Dto;

namespace PrototipoSistemaFGV.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
