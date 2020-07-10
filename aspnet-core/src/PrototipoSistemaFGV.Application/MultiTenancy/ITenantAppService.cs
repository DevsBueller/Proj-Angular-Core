using Abp.Application.Services;
using PrototipoSistemaFGV.MultiTenancy.Dto;

namespace PrototipoSistemaFGV.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

