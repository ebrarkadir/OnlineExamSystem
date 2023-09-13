using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace OnlineExamSystem.Web.Views
{
    public abstract class OnlineExamSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected OnlineExamSystemRazorPage()
        {
            LocalizationSourceName = OnlineExamSystemConsts.LocalizationSourceName;
        }
    }
}
