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
            throw new NotImplementedException();
        }

        public Institution Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Institution> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Institution institution)
        {
            throw new NotImplementedException();
        }
    }
}
