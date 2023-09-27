using Abp.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineExamSystem.Authorization;
using OnlineExamSystem.Controllers;
using OnlineExamSystem.Users;

namespace OnlineExamSystem.Web.Controllers
{
    [AbpAuthorize(PermissionNames.Pages_ExamStarts)]
    public class ExamStartsController : OnlineExamSystemControllerBase
    {
        private readonly IUserAppService _userAppService;
        public ExamStartsController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        // GET: ExamStarts
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExamStarts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamStarts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamStarts/Create
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

        // GET: ExamStarts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamStarts/Edit/5
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

        // GET: ExamStarts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamStarts/Delete/5
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
