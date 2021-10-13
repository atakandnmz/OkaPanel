using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OkaPanel.Controllers
{
    public class UrunKataloguController : Controller
    {
        public IActionResult UrunKatalogu()
        {
            return View();
        }
    }
}
