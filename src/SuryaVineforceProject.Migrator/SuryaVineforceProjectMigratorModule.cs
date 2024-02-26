using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuryaVineforceProject.Configuration;
using SuryaVineforceProject.EntityFrameworkCore;
using SuryaVineforceProject.Migrator.DependencyInjection;

namespace SuryaVineforceProject.Migrator
{
    [DependsOn(typeof(SuryaVineforceProjectEntityFrameworkModule))]
    public class SuryaVineforceProjectMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SuryaVineforceProjectMigratorModule(SuryaVineforceProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SuryaVineforceProjectMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SuryaVineforceProjectConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SuryaVineforceProjectMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
