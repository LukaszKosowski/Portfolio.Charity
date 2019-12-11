using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Charity.Mvc.Models;
using Charity.Mvc.Context;
using Charity.Mvc.Services;
using Charity.Mvc.Services.Interfaces;

namespace Charity.Mvc.Controllers
{
	public class HomeController : Controller
	{
        private readonly IInstitutionSerwice _instytutionService;

        public HomeController(IInstitutionSerwice instytutionService)
        {
            _instytutionService = instytutionService;
        }

        public IActionResult Index()
        {
            var institutions = _instytutionService.GetAll();
            return View(institutions);
        }

        public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
