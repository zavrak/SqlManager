using System.Threading.Tasks;
using Dataplatform.SqlManager.Configuration.Dto;

namespace Dataplatform.SqlManager.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
