using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Models;
using Charity.Mvc.Context;
using Charity.Mvc.Services.Interfaces;

namespace Charity.Mvc.Services
{
    public class DonationService : IDonationService
    {
        private readonly CharityContext _context;

        public DonationService(CharityContext context)
        {
            _context = context;
        }

        public bool Create(Donation donation)
        {
            _context.Donations.Add(donation);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Donation Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Donation> GetAll()
        {
            return _context.Donations.ToList();
        }

        public bool Update(Donation donation)
        {
            throw new NotImplementedException();
        }
    }
}
