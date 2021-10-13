using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OkaPanel.Controllers
{
    public class UrunEkleController : Controller
    {
        public IActionResult UrunEkle()
        {
            return View();
        }
    }
}
