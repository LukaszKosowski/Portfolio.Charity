using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Charity.Mvc.Controllers
{
    public class DonationController : Controller
    {
        [HttpGet]
        public IActionResult Donate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Donate(int i)
        {
            return View();
        }
    }
}