using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuryaVineforceProject.Configuration;

namespace SuryaVineforceProject.Web.Startup
{
    [DependsOn(typeof(SuryaVineforceProjectWebCoreModule))]
    public class SuryaVineforceProjectWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SuryaVineforceProjectWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<SuryaVineforceProjectNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SuryaVineforceProjectWebMvcModule).GetAssembly());
        }
    }
}
