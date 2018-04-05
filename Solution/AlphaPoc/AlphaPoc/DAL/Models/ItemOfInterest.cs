using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class ItemOfInterest : AuditableEntity
    {
        public int Id { get; set; }
        public int TradePreclearanceRequestId { get; set; }
        public string IoiType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }


    }
}
