using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Models;
using Final_Prj.Repository;

namespace Final_Prj.Controllers
{
    class TaskWorkController
    {
        public TaskWorkRepository taskWorkRepository;

        public TaskWorkController()
        {
            taskWorkRepository = new TaskWorkRepository();
        }

        public string AddTask(WorkTask task)
        {

            return taskWorkRepository.AddTask(task);
        }

        public List<WorkTask> GetAllTasks()
        {
            return taskWorkRepository.GetAllTasks();
        }

        public List<WorkTask> GetTaskById(int id)
        {
            return taskWorkRepository.GetTaskById(id);
        }


        public List<WorkTask> GetTaskByName(string name)
        {
            return taskWorkRepository.GetTaskByName(name);
        }

        public string RemoveTask(string taskName)
        {
            return taskWorkRepository.RemoveTask(taskName);
        }

        public string UpdateTask(WorkTask task)
        {
            return taskWorkRepository.UpdateTask(task);
        }
        public List<WorkTask> SortTask()
        {
            return taskWorkRepository.SortTask();
        }

    }
}
