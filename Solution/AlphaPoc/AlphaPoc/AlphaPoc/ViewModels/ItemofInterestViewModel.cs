using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaPoc.ViewModels
{
    public class ItemofInterestViewModel
    {
        public string IoiType { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
