using System.Threading.Tasks;
using OnlineExamSystem.Configuration.Dto;

namespace OnlineExamSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
