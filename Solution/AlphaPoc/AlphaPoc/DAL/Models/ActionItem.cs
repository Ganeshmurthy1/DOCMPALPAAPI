using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class ActionItem
    {
        public int Id { get; set; }
        public int InvestigationId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
