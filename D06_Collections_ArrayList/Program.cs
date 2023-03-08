using System;
//introduzir o using System.Collections;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D06_Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();


            #region ArrayList: multi-value

            ArrayList listaMultivalor = new ArrayList();

            listaMultivalor.Add("Collection ArrayList");
            listaMultivalor.Add(1.5);
            listaMultivalor.Add(true);
            listaMultivalor.Add(new DateTime(2023, 02, 28));
            for (int i = 4; i < 7; i++)
            {
                listaMultivalor.Add(i);
            }

            Utility.WriteTitle("Array multi values");
            foreach (var item in listaMultivalor)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region ArrayList: Courses (objects)

            ArrayList listaCursos = new ArrayList();

            Course Curso1 = new Course(1, "Biologia", "Ciencias");
            Course Curso2 = new Course(2, "Fisica", "Ciencias");

            listaCursos.Add(Curso1);
            listaCursos.Add(Curso2);

            foreach (Course item in listaCursos)
            {
                Console.WriteLine($"{item.CourseID} / {item.CourseName} / {item.Area}");
            }
            #endregion
            Utility.TerminateConsole();
        }

    }

}
    