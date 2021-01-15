using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingExtentionWithInterfaces
{
    public class Manipulate  : IManipulate
    {
        public void AddStudent(List<Student> listOfStudent)
        {
            listOfStudent.Add(new Student(22, "sss"));
        }


    }
}
