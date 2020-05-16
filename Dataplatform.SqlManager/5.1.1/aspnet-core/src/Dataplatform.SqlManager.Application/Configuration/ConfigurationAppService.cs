using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dataplatform.SqlManager.Configuration.Dto;

namespace Dataplatform.SqlManager.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SqlManagerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
