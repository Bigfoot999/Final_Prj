using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prj.Models
{
    public interface Task
    {
         int Id { get; set; }
         string TaskName { get; set; }
         string Description { get; set; }
         DateTime DueDate { get; set; }   //deadline  
         string Status { get; set; }
         string Priority { get; set; }

    }
}
