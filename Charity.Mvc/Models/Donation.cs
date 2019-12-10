﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string Quantity { get; set; }
        public Category Categories { get; set; }
        public Institution Institutions { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime PickUpTime { get; set; }
        public string PickUpComment { get; set; }
    }
}
