using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Investigation : AuditableEntity
    {
        public int Id { get; set; }
        public int ItemOfInterestId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }


    }
}
