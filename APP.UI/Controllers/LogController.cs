using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP.UI.Controllers
{
    [Authorize]
    public class LogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}