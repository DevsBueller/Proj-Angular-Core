
using PrototipoSistemaFGV.BaseCalcules;
using PrototipoSistemaFGV.BaseCalcules.Dto;
using Abp.Domain.Repositories;
using PrototipoSistemaFGV.Authorization.BaseCalcules;
using Abp.Application.Services;
using Abp.Authorization;
using PrototipoSistemaFGV.Authorization;
using System.Linq;
using Abp.Extensions;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using Abp.Collections.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;


namespace PrototipoSistemaFGV.BaseCalcules
{

	public class BaseCalculoAppService : CrudAppService<BaseCalculo, BaseCalculoDto, int, PagedBaseCalculoResultRequestDto, BaseCalculoDto>, IBaseCalculoAppService
	{
		public BaseCalculoAppService(
		   IRepository<BaseCalculo, int> repository)
		   : base(repository)
		{

		}

	
		



	}
}

