using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoDom.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Cedula { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserAddres { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string UserPassword { get; set; }
        public int UserType { get; set; }
        public int Specialties { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }


        public User(int Id, string UserName, string Cedula)
        {
            Id = this.Id;
            UserName = this.UserName;
            Cedula = this.Cedula;

        }


    }
}
