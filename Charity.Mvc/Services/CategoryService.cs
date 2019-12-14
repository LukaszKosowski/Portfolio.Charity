using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Models;
using Charity.Mvc.Context;
using Charity.Mvc.Services.Interfaces;

namespace Charity.Mvc.Services
{
    public class CategoryService : ICategoryService
        
    {
        private readonly CharityContext _context;

        public CategoryService(CharityContext context)
        {
            _context = context;
        }

        public bool Create(Category category)
        {
            _context.Categories.Add(category);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public bool Update(Category reccategoryipe)
        {zzz
            throw new NotImplementedException();
        }
    }
}
