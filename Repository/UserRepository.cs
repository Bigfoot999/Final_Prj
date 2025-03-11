using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Models;

namespace Final_Prj.Repository
{
    class UserRepository
    {
        // mở file excel
        public String AddUser(User user)
        {
            // ghi dữ liệu vào file excel
            // code here
            //if ghi thành công thì return "Add user success"
            return "Add user success";
        }

        public string DeleteUser(int id)
        {
            //xoá user có id truyền vào
            return "Delete user success"; // chỗ này return tam thời, sau sẽ sửa là "Delete user success" nêu xoá thành công, "Delete user fail" nếu xoá thất bại
        }

        public bool Login(User user)
        {
            // gán tất cả user vào list
            // duyệt list, nếu username và password trùng với username và password truyền vào thì return "true"
            return true; // chỗ này return tam thời, sau sẽ sửa là true or false
        }

        public string UpdateUser(User user)
        {
            //xoá user cũ
            //thêm user mới
            return "Update user success";
        }

        public User GetUserById(int id)
        {
            // đọc dữ liệu từ file excel
            // gán tất cả uesr vào list
            //duyet list, nếu id trùng với id truyền vào thì return user đó
            return new User();  // chỗ này return tam thời, sau sẽ sửa là user tìm thấy
        }
   
    }
}
