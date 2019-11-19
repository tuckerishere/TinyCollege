using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollege
{
    class Courses
    {
        //fields
        private string courseID;
        private string courseTitle;
        //properties
        public string CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }
        public string CourseName
        {
            get { return CourseName; }
            set { CourseName = value; }
        }
        //constructor
        public Courses(string courseID, string courseTitle)
        {
            this.courseID = courseID;
            this.courseTitle = courseTitle;
        }
    }
}
