using System.Threading.Tasks;
using PrototipoSistemaFGV.Configuration.Dto;

namespace PrototipoSistemaFGV.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
