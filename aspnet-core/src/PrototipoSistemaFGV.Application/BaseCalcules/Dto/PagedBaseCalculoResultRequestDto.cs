using Abp.Application.Services.Dto;
using System;

namespace PrototipoSistemaFGV.BaseCalcules.Dto
{
    //custom PagedResultRequestDto
    public class PagedBaseCalculoResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }


    }
}
