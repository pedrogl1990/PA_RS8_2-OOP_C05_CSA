using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_OOP_Inheritance
{
    public class CourseIT : Course
    {

        #region Properties

        public bool Exam { get; set; }

        // se esta vai substituir a implementação herdada:
        public override string FullCourse => $"Course {CourseId}: {Area} - {CourseName}, Exam? {Exam}";

        // se quiser manter a implementação herdada e criar nova implementação:
        //public new string FullCourse => $"Course {CourseId}: {Area} - {CourseName}, Exam? {Exam}";


        #endregion

        #region Constructors

        public CourseIT() : base()
        {
            Exam = false;
        }

        public CourseIT (int courseId, string courseName, string area, bool exam) : base(courseId, courseName, area)
        {
            Exam = exam;
        }
        #endregion

        #region Methods

        public override void ReadCourse()
        {
            //invocar o método da base classe
            base.ReadCourse();
            #region Exam
            //acrescentar exam

            Console.Write("Course Exam? (0 - false, 1 - true)");

            Exam = Convert.ToBoolean(Console.ReadLine());   

            #endregion
        }


        #endregion
    }
}
