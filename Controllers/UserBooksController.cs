using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mybookapp.Controllers
{
    public class UserBooksController : Controller
    {
        // GET: UserBooksController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserBooksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserBooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserBooksController/Create
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

        // GET: UserBooksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserBooksController/Edit/5
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

        // GET: UserBooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserBooksController/Delete/5
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
