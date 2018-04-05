using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaPoc.ViewModels
{
    public class DashboardViewModel
    {

        public IReadOnlyCollection<ItemofInterestViewModel> ItemofInterestViewModel { get; set; }
        public IReadOnlyCollection<TradePreclearanceRequest> TradePreclearanceRequestViewModel { get; set; }
        public IReadOnlyCollection<CalendarEvent> CalendarEventViewModel { get; set; }
        public IReadOnlyCollection<FlaggedItem> FlaggedItem { get; set; }

    }
}
