using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingExtentionWithInterfaces.Extentions;

namespace UsingExtentionWithInterfaces
{
   class Program
    {
        static void Main(string[] args)
        {
           IManipulate dataManipulation = new Manipulate();


            Student s = new Student();
             List<Student> studentList;

          //  ManipulateDataExtention

             studentList =  s.GetListOfStudents();

            dataManipulation.UpdateStudentData(studentList, 1);

            foreach(var x in studentList)
            {
                Console.WriteLine(x.Id + "  "+  x.Name);
            }





        }
    }
}
