using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OnlineExamSystem.Configuration;
using OnlineExamSystem.EntityFrameworkCore;
using OnlineExamSystem.Migrator.DependencyInjection;

namespace OnlineExamSystem.Migrator
{
    [DependsOn(typeof(OnlineExamSystemEntityFrameworkModule))]
    public class OnlineExamSystemMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public OnlineExamSystemMigratorModule(OnlineExamSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(OnlineExamSystemMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                OnlineExamSystemConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(OnlineExamSystemMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
