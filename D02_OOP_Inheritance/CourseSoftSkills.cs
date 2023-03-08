using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D02_OOP_Inheritance
{
    internal class CourseSoftSkills : Course
    {


        #region Properties

        public string SubArea { get; set; }
        public override string FullCourse => $"Course {CourseId}: {Area} - ({SubArea}), {CourseName}";


        #endregion

        #region Constructors

        public CourseSoftSkills() : base()
        {
            SubArea = "";
        }

        public CourseSoftSkills(int courseId, string courseName, string area, string subArea) : base(courseId, courseName, area)
        {
            SubArea = subArea;
        }

        #endregion

        #region Methods

        public override void ReadCourse()
        {
            base.ReadCourse();
            Console.WriteLine("Subarea?:");
            SubArea = Console.ReadLine();
        }

        #endregion
    }
}
