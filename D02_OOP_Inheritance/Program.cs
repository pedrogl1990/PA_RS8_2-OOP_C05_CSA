using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Course

            Utility.WriteTitle("Course");
            Course course = new Course();

            course.ReadCourse();

            course.ListCourse();

            #endregion
            Console.Clear();

            #region CourseIt

            CourseIT courseIT = new CourseIT();

            Utility.WriteTitle("CourseIT");
            courseIT.ReadCourse();
            courseIT.ListCourse();

            #region CourseSoftSkills
            CourseSoftSkills courseSoftSkills  = new CourseSoftSkills();

            Utility.WriteTitle("Course Soft Skills");
            courseSoftSkills.ReadCourse();
            courseSoftSkills.ListCourse();
            #endregion

            #endregion

            Utility.TerminateConsole();
        }
    }
}
