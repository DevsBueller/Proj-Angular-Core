using Abp.Application.Services.Dto;

namespace PrototipoSistemaFGV.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

