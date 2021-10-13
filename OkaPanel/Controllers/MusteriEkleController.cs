using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OkaPanel.Controllers
{
    public class MusteriEkleController : Controller
    {
        public IActionResult MusteriEkle()
        {
            return View();
        }
    }
}
