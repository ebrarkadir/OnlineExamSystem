using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OnlineExamSystem.Configuration;

namespace OnlineExamSystem.Web.Startup
{
    [DependsOn(typeof(OnlineExamSystemWebCoreModule))]
    public class OnlineExamSystemWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OnlineExamSystemWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<OnlineExamSystemNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OnlineExamSystemWebMvcModule).GetAssembly());
        }
    }
}
