using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDLL;

namespace Student_System_Server
{
    public class StudentList
    {
        public static List<Student> Students()
        {
            List<Student> slist = new List<Student>();

            Student student1 = new Student();
            student1.Name = "Robert";
            student1.University = "Curtin";
            student1.Id = 101;

            Student student2 = new Student();
            student1.Name = "Mia";
            student1.University = "EWU";
            student1.Id = 102;

            Student student3 = new Student();
            student1.Name = "Adam";
            student1.University = "Murdoch";
            student1.Id = 101;

            slist.Add(student1);
            slist.Add(student2);
            slist.Add(student3);

            return slist;
        }
    }
}

