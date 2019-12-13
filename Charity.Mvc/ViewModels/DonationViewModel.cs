using Charity.Mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.ViewModels
{
    public class DonationViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Institution> Institutions { get; set; }

        public int DonationId { get; set; }
        public string DonationQuantity { get; set; }
        public Category DonationCategory { get; set; }
        public Institution DonationInstitution { get; set; }
        public string DonationStreet { get; set; }
        public string DonationCity { get; set; }
        public string DonationZipCode { get; set; }
        public DateTime DonationPickUpDate { get; set; }
        public DateTime DonationPickUpTime { get; set; }
        public string DonationPickUpComment { get; set; }

        public IEnumerable<SelectListItem> Instytucje { get; set; }

    }
}
