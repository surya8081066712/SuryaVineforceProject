using System.Threading.Tasks;
using SuryaVineforceProject.Configuration.Dto;

namespace SuryaVineforceProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
