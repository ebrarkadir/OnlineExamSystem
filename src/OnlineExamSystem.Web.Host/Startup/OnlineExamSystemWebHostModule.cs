using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OnlineExamSystem.Configuration;

namespace OnlineExamSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(OnlineExamSystemWebCoreModule))]
    public class OnlineExamSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OnlineExamSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OnlineExamSystemWebHostModule).GetAssembly());
        }
    }
}
