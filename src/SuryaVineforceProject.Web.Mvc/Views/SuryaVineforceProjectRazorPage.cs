using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace SuryaVineforceProject.Web.Views
{
    public abstract class SuryaVineforceProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SuryaVineforceProjectRazorPage()
        {
            LocalizationSourceName = SuryaVineforceProjectConsts.LocalizationSourceName;
        }
    }
}
