using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OkaPanel.Controllers
{
    public class KullaniciYonetimiController : Controller
    {
        public IActionResult KullaniciYonetimi()
        {
            return View();
        }
    }
}
