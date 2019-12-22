using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Context;
using Charity.Mvc.Models;
using Charity.Mvc.Services.Interfaces;

namespace Charity.Mvc.Services
{
    public class CategoriesForDonationsService : ICategoriesForDonations
    {
        private readonly CharityContext _context;

        public CategoriesForDonationsService(CharityContext context)
        {
            _context = context;
        }

        public bool Create(CategoriesForDonations cfd)
        {

            _context.CategoriesForDonation.Add(cfd);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var cfd = _context.CategoriesForDonation.SingleOrDefault(i => i.Id == id);
            if (cfd == null)
                return false;

            _context.CategoriesForDonation.Remove(cfd);
            return _context.SaveChanges() > 0;
        }

        public CategoriesForDonations Get(int id)
        {
            return _context.CategoriesForDonation.SingleOrDefault(i => i.Id == id);
        }

        public IList<CategoriesForDonations> GetAll()
        {
            return _context.CategoriesForDonation.ToList();
        }
    }
}
