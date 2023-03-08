using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace D05_OOP_Interfaces
{
    internal class Course
    {


        #region Properties

        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string Area { get; set; }


        #endregion

        #region Constructors

        public Course()
        {
            CourseId = 0;
            CourseName = "";
            Area = "";
        }

        public Course(int courseId, string courseName, string area)
        {
            CourseId = courseId;
            CourseName = courseName;
            Area = area;
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
