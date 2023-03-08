using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interfaces
{
    internal interface ICourseSoftSkills
    {
        string SubArea { get; set; }
        int CourseId { get; set; }

        string CourseName { get; set; }

        string Area { get; set; }



        void ReadCourse();

        void ListCourse();

        void ListCourse(string courseName, string area);


    }
}
