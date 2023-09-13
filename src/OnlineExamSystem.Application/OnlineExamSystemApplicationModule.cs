using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OnlineExamSystem.Authorization;

namespace OnlineExamSystem
{
    [DependsOn(
        typeof(OnlineExamSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OnlineExamSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OnlineExamSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OnlineExamSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
