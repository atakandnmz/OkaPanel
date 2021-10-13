using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OkaPanel.Controllers
{
    public class MusterilerController : Controller
    {
        public IActionResult Musteriler()
        {
            return View();
        }
    }
}
