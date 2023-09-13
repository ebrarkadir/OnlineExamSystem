using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using OnlineExamSystem.Controllers;

namespace OnlineExamSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : OnlineExamSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
