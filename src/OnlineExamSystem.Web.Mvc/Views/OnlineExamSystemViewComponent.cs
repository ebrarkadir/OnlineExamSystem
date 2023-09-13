using Abp.AspNetCore.Mvc.ViewComponents;

namespace OnlineExamSystem.Web.Views
{
    public abstract class OnlineExamSystemViewComponent : AbpViewComponent
    {
        protected OnlineExamSystemViewComponent()
        {
            LocalizationSourceName = OnlineExamSystemConsts.LocalizationSourceName;
        }
    }
}
