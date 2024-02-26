using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuryaVineforceProject.Authorization;

namespace SuryaVineforceProject
{
    [DependsOn(
        typeof(SuryaVineforceProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SuryaVineforceProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SuryaVineforceProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SuryaVineforceProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
