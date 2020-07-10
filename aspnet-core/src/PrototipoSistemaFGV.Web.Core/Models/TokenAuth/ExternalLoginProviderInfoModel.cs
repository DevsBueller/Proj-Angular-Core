using Abp.AutoMapper;
using PrototipoSistemaFGV.Authentication.External;

namespace PrototipoSistemaFGV.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
