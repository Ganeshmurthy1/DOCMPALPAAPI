// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Repositories.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;

        ICustomerRepository _customers;
        IProductRepository _products;
        IOrdersRepository _orders;
        IItemofInterestRepository _itemofInterests;
        IInvestigationRepository _investigations;
        IViolationRepository _violations;
        ITradePreclearanceRequestRepository _tradePreclearanceRequests;
        IFlaggedItemRepository _flaggedItems;
        ICalendarEventRepository _calendarEvents;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }



        public ICustomerRepository Customers
        {
            get
            {
                if (_customers == null)
                    _customers = new CustomerRepository(_context);

                return _customers;
            }
        }

        public ITradePreclearanceRequestRepository TradePreclearanceRequests
        {
            get
            {
                if (_tradePreclearanceRequests == null)
                    _tradePreclearanceRequests = new TradePreclearanceRequestRepository(_context);

                return _tradePreclearanceRequests;
            }
        }
        public IFlaggedItemRepository FlaggedItems
        {
            get
            {
                if (_flaggedItems == null)
                    _flaggedItems = new FlaggedItemRepository(_context);

                return _flaggedItems;
            }
        }
        public ICalendarEventRepository CalendarEvents
        {
            get
            {
                if (_calendarEvents == null)
                    _calendarEvents = new CalendarEventRepository(_context);

                return _calendarEvents;
            }
        }

        public IItemofInterestRepository ItemofInterests
        {
            get
            {
                if (_itemofInterests == null)
                    _itemofInterests = new ItemofInterestRepository(_context);

                return _itemofInterests;
            }
        }
        public IViolationRepository Violations
        {
            get
            {
                if (_violations == null)
                    _violations = new ViolationRepository(_context);

                return _violations;
            }
        }


        public IProductRepository Products
        {
            get
            {
                if (_products == null)
                    _products = new ProductRepository(_context);

                return _products;
            }
        }

        public IInvestigationRepository Investigations
        {
            get
            {
                if (_investigations == null)
                    _investigations = new InvestigationRepository(_context);

                return _investigations;
            }
        }

        public IOrdersRepository Orders
        {
            get
            {
                if (_orders == null)
                    _orders = new OrdersRepository(_context);

                return _orders;
            }
        }


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
