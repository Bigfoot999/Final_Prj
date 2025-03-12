using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Models;

namespace Final_Prj.Repository
{
    class ExcelFile
    {
        //mở file excel có tên là FileName
        // code here
        string FileName;
        public ExcelFile(string FileName)
        {
            this.FileName = FileName;
        }

        public int saveStudyTask(StudyTask studyTask)
        {
            // code here để lưu toàn bộ thông tin studyTask vào file excel
            return 1; // trả về 1 nếu lưu thành công, 0 nếu lưu thất bại 
        }

        public List<StudyTask> GetAllStudyTask()
        {
            // ý tưởng
            // đọc tuần tự cho đến hết từng hàng rồi gán từng giá trị của hàng vào các thuộc tính của StudyTask
            return new List<StudyTask>();
        }

        public  List<StudyTask> GetStudyTaskById(int id)
        {
            List<StudyTask> studyTasksID = new List<StudyTask>();
            // ý tưởng
            // đọc tuần tự cho đến hết từng hàng rồi gán từng giá trị của hàng vào các thuộc tính của StudyTask nếu hàng đó có cột id cần tìm
            // gán vào 1 list StudyTask rồi rturn list này
            return studyTasksID;
        }

        public List<StudyTask> GetStudyTaskByName(string name)
        {
            List<StudyTask> studyTasksName = new List<StudyTask>();
            // ý tưởng tương tự như get Task by ID
            return studyTasksName;

        }

        public string RemoveTask(string taskName)
        {
            // dò theo name để xoá, không dò theo Id vì Id có thể trùng nhau
            return "Xoá Task thành công"; // nếu xoá dược thì trả về thông báo khi xoá thành công không xoá được thì báo không xoá được
        }

        public string UpdateStudyTask(StudyTask task)
        {
            //ý tưởng là gọi hàm RemoveTask rồi gọi hàm saveStudyTask
            // check các giá trị trả về của 2 hàm trên để trả về thông báo
            return "Cập nhật Task thành công";
        }


        // ====== Work Task =========

        public int saveWorkTask(WorkTask workTask)
        {
            // code here để lưu toàn bộ thông tin studyTask vào file excel
            return 1; // trả về 1 nếu lưu thành công, 0 nếu lưu thất bại 
        }

        public List<WorkTask> GetAllWorkTask()
        {
            // ý tưởng
            // đọc tuần tự cho đến hết từng hàng rồi gán từng giá trị của hàng vào các thuộc tính của StudyTask
            return new List<WorkTask>();
        }

        public List<WorkTask> GetWorkTaskById(int id)
        {
            List<WorkTask> workTasksID = new List<WorkTask>();
            // ý tưởng
            // đọc tuần tự cho đến hết từng hàng rồi gán từng giá trị của hàng vào các thuộc tính của StudyTask nếu hàng đó có cột id cần tìm
            // gán vào 1 list StudyTask rồi rturn list này
            return workTasksID;
        }

        public List<WorkTask> GetWorkTaskByName(string name)
        {
            List<WorkTask> workTasksName = new List<WorkTask>();
            // ý tưởng tương tự như get Task by ID
            return workTasksName;
        }

        public string UpdateWorkTask(WorkTask task)
        {
            //ý tưởng là gọi hàm RemoveTask rồi gọi hàm saveWorkTask
            // check các giá trị trả về của 2 hàm trên để trả về thông báo
            return "Cập nhật Task thành công";
        }
    }
}
