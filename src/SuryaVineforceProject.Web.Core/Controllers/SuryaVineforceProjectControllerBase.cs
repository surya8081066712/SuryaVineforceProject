using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SuryaVineforceProject.Controllers
{
    public abstract class SuryaVineforceProjectControllerBase: AbpController
    {
        protected SuryaVineforceProjectControllerBase()
        {
            LocalizationSourceName = SuryaVineforceProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
