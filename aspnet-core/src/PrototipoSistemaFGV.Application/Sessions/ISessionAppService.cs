using System.Threading.Tasks;
using Abp.Application.Services;
using PrototipoSistemaFGV.Sessions.Dto;

namespace PrototipoSistemaFGV.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
