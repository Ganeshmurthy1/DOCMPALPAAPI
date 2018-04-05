using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ItemofInterestRepository : Repository<ItemOfInterest>, IItemofInterestRepository
    {
        public ItemofInterestRepository(ApplicationDbContext context) : base(context)
        { }

      



        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
