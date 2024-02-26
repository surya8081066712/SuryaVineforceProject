using Abp.AutoMapper;
using SuryaVineforceProject.Sessions.Dto;

namespace SuryaVineforceProject.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
