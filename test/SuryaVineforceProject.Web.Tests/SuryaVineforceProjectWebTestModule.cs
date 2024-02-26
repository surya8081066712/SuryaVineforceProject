using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuryaVineforceProject.EntityFrameworkCore;
using SuryaVineforceProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SuryaVineforceProject.Web.Tests
{
    [DependsOn(
        typeof(SuryaVineforceProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SuryaVineforceProjectWebTestModule : AbpModule
    {
        public SuryaVineforceProjectWebTestModule(SuryaVineforceProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SuryaVineforceProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SuryaVineforceProjectWebMvcModule).Assembly);
        }
    }
}