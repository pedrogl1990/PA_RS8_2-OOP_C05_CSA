//Encapsulation
//Public class member: methods, properties
//Private class members: fields or attributes, variabes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP_Encapsulation
{
    public class Course
    {

        #region Fields
        private string courseName; //suporte da propriedade clássica
        private string area; // suporte da propriedade bodied-expression (usa-se o operado lambda (=>))

        #endregion

        #region Properties

        // Auto-implemented (propriedade automática): criada com o snipet prop
        public int CourseId { get; set; }

        // Classic: usa um field
        public string CourseName
        {
            get { return courseName; }      // read
            set { courseName = value; }     // write
        }

        // Bodied-expression (apto para expressão): usa um field e operador lambda (=>); snipet propfull

        public string Area
        {
            get => area;
            set => area = value;
        }

        // Read-only

        public string FullCourse => $"Course {CourseId}: {Area} - {CourseName}";
        #endregion

        #region Methods
        // Read all course values

        public void ReadCourse()
        {
            #region CourseId
            int courseId;
            Console.Write("Course Id: ");
            bool converted = int.TryParse(Console.ReadLine(), out courseId);
            if (converted)
            {
                CourseId = courseId;
            }
            #endregion

            #region Area
            Console.Write("Area: ");
            Area = Console.ReadLine();
            #endregion

            #region CourseName
            Console.Write("Course Name: ");
            CourseName = Console.ReadLine();
            #endregion
        }

        // List course info

        public void ListCourse()
        {
            Console.WriteLine($"\n\n{FullCourse}");
        }

        #endregion

    }
}
