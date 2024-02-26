using Abp.AspNetCore.Mvc.ViewComponents;

namespace SuryaVineforceProject.Web.Views
{
    public abstract class SuryaVineforceProjectViewComponent : AbpViewComponent
    {
        protected SuryaVineforceProjectViewComponent()
        {
            LocalizationSourceName = SuryaVineforceProjectConsts.LocalizationSourceName;
        }
    }
}
