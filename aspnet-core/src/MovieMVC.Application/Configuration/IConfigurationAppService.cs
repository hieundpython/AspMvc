using System.Threading.Tasks;
using MovieMVC.Configuration.Dto;

namespace MovieMVC.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
