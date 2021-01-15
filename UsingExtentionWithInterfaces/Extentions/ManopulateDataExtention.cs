using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingExtentionWithInterfaces.Extentions
{
   
     public static class ManipulateDataExtention
    {
       
        public static void UpdateStudentData(this IManipulate manipulateData,List<Student> studentList, int studentId)
        {
           var student = studentList.Where(x => x.Id == studentId).Single();

            student.Name = "ARUNAVA BANERJEE";
            student.Id = 1014;

        }

    }
}
