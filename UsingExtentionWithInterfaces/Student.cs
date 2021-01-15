using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingExtentionWithInterfaces
{
   public class Student
    {

       
        public string Name { get; set; }
        public int Id { get; set; }

        public Student(int id, string name)
        {
            Name = name;
            Id = id;

        }
        public Student()
        {

        }




        public List<Student> GetListOfStudents()
        {

            List<Student> listOfStudents = new List<Student>()
            {
              new Student(1,"aaa"),
               new Student(2,"bbb"),
                new Student(3,"ccc"),
                 new Student(4,"ddd"),
                  new Student(5,"eee")

            };

            return listOfStudents;



        }
    }

}