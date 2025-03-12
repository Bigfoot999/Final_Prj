using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prj.Models
{
    class WorkTask : TaskEntity , IComparable<WorkTask>
    {
        public string TaskType { get; set; }  //Loại công việc
        public WorkTask(int id, string taskName, string description, DateTime dueDate, string status, string priority, string taskType): 
            base(id, taskName, description, dueDate, status, priority)
        {
            this.TaskType = taskType;
        }
        public WorkTask() : base()
        {
        }
        //So sánh 2 task theo deadline
        public int CompareTo(WorkTask other)
        {
            if (other == null)
                return 1;
            return this.DueDate.CompareTo(other.DueDate);
        }
    }

}
