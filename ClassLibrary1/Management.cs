using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Management
    {
        static List<School_database_1> list = new List<School_database_1>()
        {
           new School_database_1(){StudentId=1,StudentName="Harish",TeacherName="Divya",SubjectName="Science"},
           new School_database_1(){StudentId=2,StudentName="Shyam",TeacherName="Merlin",SubjectName="Maths"},
          new School_database_1(){StudentId=3,StudentName="Prabha",TeacherName="Deepa",SubjectName="Chemistry"},
          new School_database_1(){StudentId=4,StudentName="Vidhya",TeacherName="Nandhini",SubjectName="Physics"},
          new School_database_1(){StudentId=5,StudentName="Gowtham",TeacherName="Prabhu",SubjectName="Social"},



        };
        public List<School_database_1> Allstulist()
        {
            return list;
        }
        public List<School_database_1> SearchStu(int id)
        {
            List<School_database_1> searchlist = list.FindAll(s => s.StudentId == id);
            return searchlist;

        }
        public virtual bool StudentMarks()
        {
            return false;
        }
    }
}
