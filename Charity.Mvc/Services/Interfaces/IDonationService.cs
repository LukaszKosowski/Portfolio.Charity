using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Models;

namespace Charity.Mvc.Services.Interfaces
{
    public interface IDonationService
    {
        bool Create(Donation donation);
        bool Delete(int id);
        Donation Get(int id);
        IList<Donation> GetAll();
        bool Update(Donation donation);
    }
}
