using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;

namespace TimeManagement.Areas.Admin.Controllers
{
    [Area("admin")]
    public class UserManagemnetController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserManagemnetController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [Route("admin/userlist")]
        // GET: UserManagemnetController
        public async Task<ActionResult> Index()
        {
            var userQuery = await _userManager.Users.ToListAsync();

            return View(userQuery);
        }


        [Route("admin/userdetail")]
        // GET: UserManagemnetController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            

            var userQuery = await _userManager.FindByIdAsync(id);

            return View(userQuery);
        }



        [Route("admin/useredit")]
        // GET: UserManagemnetController/Edit/5
        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {
            var userQuery = await _userManager.FindByIdAsync(id);
            return View(userQuery);
        }

        [Route("admin/useredit")]
        // POST: UserManagemnetController/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(string id, AppUser appUser)
        {
            try
            {
                var userQuery = await _userManager.FindByIdAsync(appUser.Id.ToString());

                if (userQuery != null )
                {
                    
                    userQuery.FirstName = appUser.FirstName;
                    userQuery.LastName = appUser.LastName;
                    
                   await _userManager.UpdateAsync(userQuery);

                }
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [Route("admin/userdelete")]
        [HttpGet]
        // GET: UserManagemnetController/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            var userQuery = await _userManager.FindByIdAsync(id);
            return View(userQuery);
        }

        [Route("admin/userdelete")]
        // POST: UserManagemnetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, AppUser appUser)
        {
            try
            {
                var userQuery = await _userManager.FindByIdAsync(appUser.Id.ToString());

                if (userQuery!=null)
                {
                    await _userManager.DeleteAsync(userQuery);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
