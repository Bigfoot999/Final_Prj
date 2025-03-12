using System;
using System.Collections.Generic;
using Final_Prj.Models;
using Final_Prj.Repository;

namespace Final_Prj.Controllers
{
    class TaskStudyController 
    {
        public TaskStudyRepository taskStudyRepository;
        public TaskStudyController() :base()
        {
            taskStudyRepository = new TaskStudyRepository();
        }
        public  string AddTask(StudyTask task)
        {
            
            return taskStudyRepository.AddTask(task);
        }

        public  List<StudyTask> GetAllTasks()
        {
            return taskStudyRepository.GetAllTasks();
        }

        public  List<StudyTask> GetTaskById(int id)
        {
            return taskStudyRepository.GetTaskById(id);
        }
       

        public  List<StudyTask> GetTaskByName(string name)
        {
            return taskStudyRepository.GetTaskByName(name);
        }

        public string RemoveTask(string taskName)
        {
            return taskStudyRepository.RemoveTask(taskName);
        }

        public string UpdateTask(StudyTask task)
        {
            return taskStudyRepository.UpdateTask(task);
        }
        public List<StudyTask> SortTask()
        {
            return taskStudyRepository.SortTask();
        }

    }
}
