using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using OnlineExamSystem.Controllers;

namespace OnlineExamSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : OnlineExamSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
