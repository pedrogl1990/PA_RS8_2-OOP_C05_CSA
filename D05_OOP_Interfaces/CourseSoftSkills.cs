using D05_OOP_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D03_OOP_Polymorphism
{
    internal class CourseSoftSkills : ICourseSoftSkills
    {


        #region Properties

        public string SubArea { get; set; }
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string Area { get; set; }


        #endregion

        #region Constructors

        public CourseSoftSkills()
        {
            CourseId = 0;
            CourseName = "";
            Area = "";
            SubArea= "";
        }

        public CourseSoftSkills(int courseId, string courseName, string area, string subArea)
        {
            CourseId = courseId;
            CourseName = courseName;
            Area = area;
            SubArea = subArea;
        }

        #endregion

        #region Methods

        public virtual void ReadCourse()
        {

        }

        public void ListCourse()
        {

        }

        public void ListCourse(string courseName, string area)
        {

        }
        #endregion
    }
}
