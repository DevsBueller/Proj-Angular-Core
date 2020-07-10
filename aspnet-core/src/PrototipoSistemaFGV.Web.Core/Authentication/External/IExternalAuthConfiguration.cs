using System.Collections.Generic;

namespace PrototipoSistemaFGV.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
