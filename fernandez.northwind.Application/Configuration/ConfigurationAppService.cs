using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using fernandez.northwind.Configuration.Dto;

namespace fernandez.northwind.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : northwindAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
