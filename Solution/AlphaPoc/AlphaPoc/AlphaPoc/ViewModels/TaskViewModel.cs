using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaPoc.ViewModels
{
    public class TaskViewModel
    {
        public int Id { get; set; }

        public int DaystoViolation { get; set; }

        public string Name { get; set; }
        public string Item { get; set; }

        public string Status { get; set; }



    }

    public class ToDoList
    {
        public int Id { get; set; }
        public string ItemState { get; set; }
        public string ItemValue { get; set; }
        public string ItemText { get; set; }

    }
}
