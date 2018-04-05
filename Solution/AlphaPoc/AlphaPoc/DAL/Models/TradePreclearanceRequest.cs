using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class TradePreclearanceRequest : AuditableEntity
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int DaysToViolation { get; set; }

        public DateTime TradeDate { get; set; }
        public string SecurityName { get; set; }
        public string Description { get; set; }


        public string TradeType { get; set; }
        public string Status { get; set; }
    }
}
