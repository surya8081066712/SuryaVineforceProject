using System.Threading.Tasks;
using Abp.Application.Services;
using SuryaVineforceProject.Sessions.Dto;

namespace SuryaVineforceProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
