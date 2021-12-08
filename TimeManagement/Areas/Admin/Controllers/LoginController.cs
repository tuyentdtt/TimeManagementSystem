using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Areas.Admin.Controllers
{
    [Area("admin")]
    public class LoginController : Controller
    {
        
        [Route("admin/login")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
