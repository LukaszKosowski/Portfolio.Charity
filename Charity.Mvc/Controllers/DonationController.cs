using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Charity.Mvc.Controllers
{
    public class DonationController : Controller
    {
        private readonly IInstitutionSerwice _instytutionService;
        private readonly ICategoryService _categoryService;

        public DonationController(IInstitutionSerwice instytutionService, ICategoryService categoryService)
        {
            _instytutionService = instytutionService;
            _categoryService = categoryService;
        }
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