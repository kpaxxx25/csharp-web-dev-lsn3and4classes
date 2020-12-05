using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student myStudent = new Student("Kirin", 5, 1, 4.0);

            Console.WriteLine(myStudent);
            Console.WriteLine(myStudent.Name);

            Teacher myTeacher = new Teacher("Mary", "Jane", "Biology", 20);

            Console.WriteLine(myTeacher);
            Console.WriteLine(myTeacher.FirstName + " " + myTeacher.LastName);

            Course myCourse = new Course();
            myCourse.Instructor = myTeacher;

            Console.WriteLine(myCourse.Instructor);
        }
    }
}
