using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Violation : AuditableEntity
    {
        public int Id { get; set; }
        public int InvestigationId { get; set; }
        public bool IsResolved { get; set; }
        public string ViolationType { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }


    }
}
