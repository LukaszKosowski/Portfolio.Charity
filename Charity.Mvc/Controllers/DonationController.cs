using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Models;
using Charity.Mvc.Services.Interfaces;
using Charity.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Charity.Mvc.Controllers
{
    public class DonationController : Controller
    {
        private readonly IInstitutionSerwice _instytutionService;
        private readonly ICategoryService _categoryService;
        private readonly IDonationService _donationService;

        public DonationController(IInstitutionSerwice instytutionService,
                                ICategoryService categoryService,
                                IDonationService donationService)
        {
            _instytutionService = instytutionService;
            _categoryService = categoryService;
            _donationService = donationService;
        }
        [HttpGet]
        public IActionResult Donate()
        {
            List<string> ListaKategorii = new List<string>();

            foreach(Institution c in _instytutionService.GetAll())
            {
                ListaKategorii.Add(c.Name);
            }

            DonationViewModel donationViewModel = new DonationViewModel
            {
                Categories = (List<Category>)_categoryService.GetAll(),
                Institutions = _instytutionService.GetAll(),
                Instytucje = new SelectList(ListaKategorii)
            };

            return View(donationViewModel);
        }

        [HttpPost]
        public IActionResult Donate(DonationViewModel donationModelView)
        {
            // Create new Donation

            return View();
        }
    }
}