using Abp.Application.Services;
using SuryaVineforceProject.MultiTenancy.Dto;

namespace SuryaVineforceProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

