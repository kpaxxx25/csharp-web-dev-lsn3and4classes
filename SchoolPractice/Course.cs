using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string Topic { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        //no idea on this part
        public Course(string topic, Teacher teacher, List<Student> enrolledStudents)
        {
            Topic = topic;
            Teacher.LastName = teacher;
            List<Student> = enrolledStudents;
        }
    }
}
