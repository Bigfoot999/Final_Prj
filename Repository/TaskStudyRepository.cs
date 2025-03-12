using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Models;

namespace Final_Prj.Repository
{
    class TaskStudyRepository
    {
        public ExcelFile excelFile_StudyTask;
        public TaskStudyRepository()
        {
            excelFile_StudyTask = new ExcelFile("StudyTask.xlsx");
        }
        public string AddTask(StudyTask studyTask)
        {
            int value = excelFile_StudyTask.save(studyTask);
            if (value == 1)
                return "Lưu task thành công";
            else
                return "Lưu task thất bại";
        }

        public List<StudyTask> GetAllTasks()
        {
            return excelFile_StudyTask.GetAllTask();
        }

        public List<StudyTask> GetTaskById(int id)
        {
            return excelFile_StudyTask.GetTaskById(id);

        public List<StudyTask> GetTaskByName(string name)
        {
            return excelFile_StudyTask.GetTaskByName(name);
        }

        public string RemoveTask(StudyTask taskStudy)
        {
            return excelFile_StudyTask.RemoveTask(taskStudy);
        }



        public string UpdateTask(StudyTask task)
        {
            return excelFile_StudyTask.UpdateTask(task);
        }
        public List<StudyTask> SortTask()
        {
            List<StudyTask> studyTasks = GetAllTasks();
            studyTasks.Sort();
            return studyTasks;
        }
    }
}
