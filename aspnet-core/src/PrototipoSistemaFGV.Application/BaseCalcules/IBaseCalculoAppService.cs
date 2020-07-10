using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PrototipoSistemaFGV.Roles.Dto;
using PrototipoSistemaFGV.BaseCalcules.Dto;

using PrototipoSistemaFGV.Authorization.BaseCalcules;

namespace PrototipoSistemaFGV.BaseCalcules
{
	public interface IBaseCalculoAppService : ICrudAppService<BaseCalculoDto, int, PagedBaseCalculoResultRequestDto>
	{



	}
}
