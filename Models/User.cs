using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Prj.Models
{
    class User
    {
        static int id = 1;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
            id++;

        }
        public User( string username, string password)
        {
            id = id + 1;
            Username = username;
            Password = password;
            id++;

        }
        public User()
        {
        }
       

        public override string ToString()
        {
            return $"Id: {Id}, Username: {Username}, Password: {Password}";
        }

    }

}
