using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuryaVineforceProject.Configuration;

namespace SuryaVineforceProject.Web.Host.Startup
{
    [DependsOn(
       typeof(SuryaVineforceProjectWebCoreModule))]
    public class SuryaVineforceProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SuryaVineforceProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SuryaVineforceProjectWebHostModule).GetAssembly());
        }
    }
}
