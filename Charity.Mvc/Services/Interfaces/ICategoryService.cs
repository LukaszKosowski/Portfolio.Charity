using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Services.Interfaces
{
    public interface ICategoryService
    {
        bool Create(Category category);
        bool Delete(int id);
        Category Get(int id);
        IList<Category> GetAll();
        bool Update(Category category);
    }
}
