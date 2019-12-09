using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Models;

namespace Charity.Mvc.Services.Interfaces
{
    interface IInstitutionSerwice
    {
        bool Create(Institution institution);
        bool Delete(int id);
        Institution Get(int id);
        IList<Institution> GetAll();
        bool Update(Institution institution);
    }
}
