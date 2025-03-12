using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Repository;

namespace Final_Prj.Models
{
    class StudyTask : TaskEntity, IComparable<StudyTask>
    {
   
        public string Subject { get; set; }  //Môn học

        public StudyTask(int id, string taskName, string description, DateTime dueDate, string status, string priority, string subject)
        : base(id, taskName, description, dueDate, status, priority)
        {
            this.Subject = subject;
        }

        public StudyTask() :base()
        {
        }

        //So sánh 2 task theo deadline
        public int CompareTo(StudyTask other)
        {
            if (other == null)
                return 1;
            return this.DueDate.CompareTo(other.DueDate);
        }
    }
}
