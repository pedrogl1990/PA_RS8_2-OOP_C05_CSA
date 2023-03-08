using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region CourseIT
            CourseIT courseIT = new CourseIT();
            Utility.WriteTitle("Course IT");
            courseIT.ReadCourse();

            //polimorfismo a funcionar
            courseIT.ListCourse();
            courseIT.ListCourse(DateTime.Now);

            #endregion

            #region CourseSoftSkills
            CourseSoftSkills courseSoftSkills = new CourseSoftSkills();
            Utility.WriteTitle("Course Soft Skills");
            courseSoftSkills.ReadCourse();
            courseSoftSkills.ListCourse();
            courseSoftSkills.ListCourse("Nivel Iniciante");
            #endregion

            Utility.TerminateConsole();
        }
    }
}
