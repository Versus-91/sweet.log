using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using sweet.log.Configuration.Dto;

namespace sweet.log.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : logAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
