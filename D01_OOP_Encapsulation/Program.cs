using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Course course = new Course();

            course.ReadCourse();
            course.ListCourse();
       

            Utility.TerminateConsole();
        }
    }
}
