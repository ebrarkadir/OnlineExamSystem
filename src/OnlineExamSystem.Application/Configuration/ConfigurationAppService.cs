using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OnlineExamSystem.Configuration.Dto;

namespace OnlineExamSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OnlineExamSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
