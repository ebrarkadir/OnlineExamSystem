using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineExamSystem.Authorization;
using OnlineExamSystem.Controllers;
using OnlineExamSystem.Users;

namespace OnlineExamSystem.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Exams)]
    public class ExamsController : OnlineExamSystemControllerBase
    {
        private readonly IUserAppService _userAppService;

        public ExamsController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        // GET: ExamsController
        public ActionResult Index()
        {
            return View();  
        }

        // GET: ExamsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExamsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExamsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
