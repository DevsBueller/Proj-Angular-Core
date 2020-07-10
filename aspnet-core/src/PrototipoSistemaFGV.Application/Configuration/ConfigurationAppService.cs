using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PrototipoSistemaFGV.Configuration.Dto;

namespace PrototipoSistemaFGV.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PrototipoSistemaFGVAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
