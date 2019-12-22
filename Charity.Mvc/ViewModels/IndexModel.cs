using Charity.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.ViewModels
{
    public class IndexModel
    {
        public int Quantity { get; set; }
        public int AllInstitutions { get; set; }
        public IList<Institution> InstitutionList { get; set; }
    }
}
