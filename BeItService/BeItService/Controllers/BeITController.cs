using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BeItService.Controllers
{
    public class BeITController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}