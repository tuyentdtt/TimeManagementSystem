using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Areas.Admin.Controllers
{
    [Area("admin")]
    public class UserManagemnetController : Controller
    {
        [Route("admin/userlist")]
        // GET: UserManagemnetController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserManagemnetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserManagemnetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserManagemnetController/Create
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

        // GET: UserManagemnetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserManagemnetController/Edit/5
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

        // GET: UserManagemnetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserManagemnetController/Delete/5
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
