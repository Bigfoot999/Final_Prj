using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Models;

namespace Final_Prj.Repository
{
    class TaskWorkRepository
    {
        public ExcelFile excelFile_StudyTask;
        public TaskWorkRepository()
        {
            excelFile_StudyTask = new ExcelFile("WorkTask.xlsx");
        }
        public string AddTask(WorkTask workTask)
        {
            int value = excelFile_StudyTask.saveWorkTask(workTask);
            if (value == 1)
                return "Lưu task thành công";
            else
                return "Lưu task thất bại";
        }

        public List<WorkTask> GetAllTasks()
        {
            return excelFile_StudyTask.GetAllWorkTask();
        }

        public List<WorkTask> GetTaskById(int id)
        {
            return excelFile_StudyTask.GetWorkTaskById(id);
        }
        public List<WorkTask> GetTaskByName(string name)
        {
            return excelFile_StudyTask.GetWorkTaskByName(name);
        }

        public string RemoveTask(string taskName)
        {
            return excelFile_StudyTask.RemoveTask(taskName);
        }



        public string UpdateTask(WorkTask task)
        {
            return excelFile_StudyTask.UpdateWorkTask(task);
        }
        public List<WorkTask> SortTask()
        {
            List<WorkTask> studyTasks = GetAllTasks();
            studyTasks.Sort();
            return studyTasks;
        }
    }
}
