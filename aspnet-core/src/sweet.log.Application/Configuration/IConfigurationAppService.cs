using System.Threading.Tasks;
using sweet.log.Configuration.Dto;

namespace sweet.log.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
