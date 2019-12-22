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
using Charity.Mvc.ViewModels;

namespace Charity.Mvc.Controllers
{
	public class HomeController : Controller
	{
        private readonly IInstitutionSerwice _instytutionService;
        private readonly ICategoryService _categoryService;
        private readonly IDonationService _donationService;
        private readonly ICategoriesForDonations _categoriesForDonation;

        public HomeController(IInstitutionSerwice instytutionService,
                                ICategoryService categoryService,
                                IDonationService donationService,
                                ICategoriesForDonations categoriesForDonation)
        {
            _instytutionService = instytutionService;
            _categoryService = categoryService;
            _donationService = donationService;
            _categoriesForDonation = categoriesForDonation;
        }

        public IActionResult Index()
        {
            IEnumerable<Donation> AllDonations = _donationService.GetAll();
            int qq = 0;
            var ii = AllDonations.Select(x => x.Id).Distinct();

            foreach(Donation d in AllDonations)
            {
                qq += d.Quantity;
                //ii += d.Institutions.Id;
            }

            IndexModel indexModel = new IndexModel
            {
                Quantity = qq,
                AllInstitutions = ii.Count(),
                InstitutionList  = _instytutionService.GetAll()
            };

            return View(indexModel);
        }

        public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
