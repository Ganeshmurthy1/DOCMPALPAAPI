// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }
        IOrdersRepository Orders { get; }
        IItemofInterestRepository ItemofInterests { get; }
        IInvestigationRepository Investigations { get; }
        IViolationRepository Violations { get; }
        ITradePreclearanceRequestRepository TradePreclearanceRequests { get; }
        IFlaggedItemRepository FlaggedItems { get; }
        ICalendarEventRepository CalendarEvents { get; }
        int SaveChanges();
    }
}
