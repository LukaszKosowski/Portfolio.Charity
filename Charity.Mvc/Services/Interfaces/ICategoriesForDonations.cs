using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services.Interfaces
{
    public interface ICategoriesForDonations
    {
        bool Create(CategoriesForDonations category);
        bool Delete(int id);
        CategoriesForDonations Get(int id);
        IList<CategoriesForDonations> GetAll();
    }
}
