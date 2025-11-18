using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    
    struct Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool Gender { get; set; }

        public Student(int id, string name, string surname,bool gender )
        {
            Id = id;
            Name = name;
            SurName = surname;
            Gender = gender;
        }
    }
}
