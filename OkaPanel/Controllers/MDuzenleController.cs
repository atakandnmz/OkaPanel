using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OkaPanel.Controllers
{
    public class MDuzenleController : Controller
    {
        public IActionResult MDuzenle()
        {
            return View();
        }
        public IActionResult Servis()
        {
            return View();
        }

        public IActionResult Sil()
        {
            return View();
        }

    }
}
