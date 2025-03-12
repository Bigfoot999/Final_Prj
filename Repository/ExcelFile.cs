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

        public int save(StudyTask studyTask)
        {
            // code here để lưu toàn bộ thông tin stuuTask vào file excel
            return 1; // trả về 1 nếu lưu thành công, 0 nếu lưu thất bại 
        }

        internal List<StudyTask> GetAllTask()
        {
            // ý tưởng
            // đọc tuần tự cho đến hết từng hàng rồi gán từng giá trị của hàng vào các thuộc tính của StudyTask
            return new List<StudyTask>();
        }

        public  List<StudyTask> GetTaskById(int id)
        {
            List<StudyTask> studyTasksID = new List<StudyTask>();
            // ý tưởng
            // đọc tuần tự cho đến hết từng hàng rồi gán từng giá trị của hàng vào các thuộc tính của StudyTask nếu hàng đó có cột id cần tìm
            // gán vào 1 list StudyTask rồi rturn list này
            return studyTasksID;
        }

        internal List<StudyTask> GetTaskByName(string name)
        {
            List<StudyTask> studyTasksName = new List<StudyTask>();
            // ý tưởng tương tự như get Task by ID
            return studyTasksName;

        }

        public string RemoveTask(StudyTask taskStudy)
        {
            // chưa có ý tưởng
            return "Xoá Task thành công"; // nếu xoá dược thì trả về thông báo khi xoá thành công không xoá được thì báo không xoá được
        }

        public string UpdateTask(StudyTask task)
        {
            //ý tưởng là gọi hàm RemoveTask rồi gọi hàm save
            // check các giá trị trả về của 2 hàm trên để trả về thông báo
            return "Cập nhật Task thành công";
        }
    }
}
