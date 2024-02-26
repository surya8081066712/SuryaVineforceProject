using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SuryaVineforceProject.Controllers;

namespace SuryaVineforceProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SuryaVineforceProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
