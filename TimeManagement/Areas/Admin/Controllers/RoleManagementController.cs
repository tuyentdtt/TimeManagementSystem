using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Areas.Admin.Models;
using TimeManagement.Data;
using TimeManagement.Entity;
using TimeManagement.Models;

namespace TimeManagement.Areas.Admin.Controllers
{
    [Area("admin")]
    public class RoleManagementController : Controller
    {

        private readonly ApplicationDbContext _context;
        //private readonly UserManager<AppUser> _userManager;

        

        private readonly RoleManager<AppRole> _roleManager;

        private readonly UserManager<AppUser> _userManager;
        public RoleManagementController(ApplicationDbContext context, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Route("admin/rolelist")]
        // GET: RoleManagementController
        public async Task<ActionResult> Index()
        {
            var roleQuery = await _roleManager.Roles.ToListAsync();
            return View(roleQuery);
        }


        [Route("admin/roledetail")]
        // GET: RoleManagementController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            var roleQuery = await _roleManager.FindByIdAsync(id);

            return View(roleQuery);
        }


        [Route("admin/rolecreate")]
        [HttpGet]
        // GET: RoleManagementController/Create
        public ActionResult Create()
        {

            return View();
        }

        [Route("admin/rolecreate")]
        // POST: RoleManagementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AppRole appRole)
        {
            try
            {

                var hasher = new PasswordHasher<AppUser>();
                string NormalizedName = appRole.Name.ToUpper();
                var CreateRole = new AppRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = appRole.Name,
                    NormalizedName = NormalizedName
                };

                await _roleManager.CreateAsync(CreateRole);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [Route("admin/roleedit")]
        [HttpGet]
        // GET: RoleManagementController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            var roleQuery = await _roleManager.FindByIdAsync(id);
            return View(roleQuery);
        }

        [Route("admin/roleedit")]
        // POST: RoleManagementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, AppRole appRole)
        {
            try
            {
                var roleQuery = await _roleManager.FindByIdAsync(appRole.Id);
                

                roleQuery.Name = appRole.Name;

                await _roleManager.UpdateAsync(roleQuery);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [Route("admin/roledelete")]
        [HttpGet]
        // GET: RoleManagementController/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            var roleQuery = await _roleManager.FindByIdAsync(id);

            return View(roleQuery);
        }

        [Route("admin/roledelete")]
        // POST: RoleManagementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, AppRole appRole)
        {
            try
            {
                var roleQuery = await _roleManager.FindByIdAsync(appRole.Id);

               


                await _roleManager.DeleteAsync(roleQuery);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
