using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Controllers
{
    public class LichController : Controller
    {
        public LichController()
        {

        }

        [Route("lich")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
