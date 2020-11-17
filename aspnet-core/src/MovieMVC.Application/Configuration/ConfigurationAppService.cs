using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MovieMVC.Configuration.Dto;

namespace MovieMVC.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MovieMVCAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
