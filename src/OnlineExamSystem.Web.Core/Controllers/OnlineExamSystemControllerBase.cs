using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OnlineExamSystem.Controllers
{
    public abstract class OnlineExamSystemControllerBase: AbpController
    {
        protected OnlineExamSystemControllerBase()
        {
            LocalizationSourceName = OnlineExamSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
