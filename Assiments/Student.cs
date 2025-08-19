using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Student
    {

        private int Id;
        private string Name;
        private String Email;

        public Student(int id , String n , String e) 
        {
        this.Id = id;
        this.Name = n;
        this.Email = e;
        }

        public int id { get { return Id; } set { Id = value; } }
        public string name { get { return Name; } set { Name = value; } }
        public String email { get { return Email; } set { Email = value; } }


    }
}
