using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaPoc.ViewModels;
using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlphaPoc.Controllers
{

    [Route("api/[controller]")]
    public class DashboardController : Controller
    {

        private IUnitOfWork _unitOfWork;

        public DashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(typeof(DashboardViewModel),200)]
        public IActionResult Get()
        {
            var dashboardViewModel = new DashboardViewModel
            {
                CalendarEventViewModel=GetCalendarEvents(),
                FlaggedItem=GetFlaggedItems(),
                ItemofInterestViewModel=GetItemofInterests(),
                TradePreclearanceRequestViewModel=GetTradePreclearanceRequests()
            };

            return Ok(dashboardViewModel);
        }
        [HttpGet]
        [ProducesResponseType(typeof(CalendarEvent), 200)]
        public IActionResult GetCalendarEventDetail(int id)
        {
            var detail = _unitOfWork.CalendarEvents.Get(id);

            return Ok(detail);
        }


        private IReadOnlyCollection<ItemofInterestViewModel> GetItemofInterests()
        {
            var allrequests = _unitOfWork.ItemofInterests.GetAll();

            var iois = new List<ItemofInterestViewModel>();

            foreach(var item in allrequests)
            {
                iois.Add(new ItemofInterestViewModel
                {
                    CreatedDate=item.CreatedDate,
                    Description=item.Description,
                    Id=item.Id,
                    IoiType=item.IoiType
                });
            }
            return iois;
        }

        private IReadOnlyCollection<TradePreclearanceRequest> GetTradePreclearanceRequests()
        {
            return _unitOfWork.TradePreclearanceRequests.GetAll().ToList();
        }
        private IReadOnlyCollection<FlaggedItem> GetFlaggedItems()
        {

           return  _unitOfWork.FlaggedItems.GetAll().ToList();
        }

        private IReadOnlyCollection<CalendarEvent> GetCalendarEvents()
        {
            

            return _unitOfWork.CalendarEvents.GetAll().ToList();
        }
    }
}