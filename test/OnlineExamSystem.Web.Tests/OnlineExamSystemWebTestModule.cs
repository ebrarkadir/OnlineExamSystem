using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OnlineExamSystem.EntityFrameworkCore;
using OnlineExamSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace OnlineExamSystem.Web.Tests
{
    [DependsOn(
        typeof(OnlineExamSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class OnlineExamSystemWebTestModule : AbpModule
    {
        public OnlineExamSystemWebTestModule(OnlineExamSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OnlineExamSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(OnlineExamSystemWebMvcModule).Assembly);
        }
    }
}