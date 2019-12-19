using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Models;
using Charity.Mvc.Context;
using Charity.Mvc.Services.Interfaces;

namespace Charity.Mvc.Services
{
    public class InstitutionSerwice : IInstitutionSerwice
    {
        private readonly CharityContext _context;

        public InstitutionSerwice(CharityContext context)
        {
            _context = context;
        }

        public bool Create(Institution institution)
        {
            _context.Institutions.Add(institution);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var institution = _context.Institutions.SingleOrDefault(i => i.Id == id);
            if (institution == null)
                return false;

            _context.Institutions.Remove(institution);
            return _context.SaveChanges() > 0;
        }

        public Institution Get(int id)
        {
            return _context.Institutions.SingleOrDefault(i => i.Id == id);
        }

        public List<Institution> GetAll()
        {
            return _context.Institutions.ToList();
        }

        public bool Update(Institution institution)
        {
            _context.Institutions.Update(institution);
            return _context.SaveChanges() > 0;
        }
    }
}
