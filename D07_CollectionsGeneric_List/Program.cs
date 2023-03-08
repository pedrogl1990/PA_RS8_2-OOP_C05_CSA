using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D07_CollectionsGeneric_List 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region List: ints

            List<int> listIntegers = new List<int>();

            for (int i = 0;i < 5; i++) 
            { 
                listIntegers.Add(i); 
            }

            Utility.WriteTitle("List Integers");

            foreach (int item in listIntegers)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region List: courses

            Course course1 = new Course(1, "Biologia", "Ciencias");
            Course course2 = new Course(2, "Programação", "Devs");

            List<Course> listCourses = new List<Course>();

            listCourses.Add(course1);
            listCourses.Add(course2);

            foreach (Course item in listCourses)
            {
                Console.WriteLine($"{item.CourseID} / {item.CourseName} / {item.Area}");
            }

            #endregion

            Utility.TerminateConsole();

        }
    }
}
