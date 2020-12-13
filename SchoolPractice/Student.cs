using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        // Update the appropriate properties: NumberOfCredits, Gpa
        public void AddGrade(int credits, double grade)
        {
            double qualityScore = Gpa * NumberOfCredits;
            qualityScore += credits * grade;
            NumberOfCredits += credits;
            Gpa = qualityScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here: 
        // Determine the grade level of the student based on NumberOfCredits
        public string GetGradeLevel(int credits)
        {
            if (credits >= 90)
            {
                return "Senior";
            } else if (credits >= 60 && credits <= 89)
            {
                return "Junior";
            } else if (credits >= 30 && credits <= 59)
            {
                return "Sophmore";
            } else if (credits >= 0 && credits <= 29)
            {
                return "Freshman";
            } else { 
                return "grade level tbd";
            }
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return $"{Name} (credits: {NumberOfCredits}, GPA: {Gpa})";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        public override bool Equals(object obj)
        {
            if(this == obj)
            {
                return true;
            }
            if(obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            //turning 1 obj into another
            //(Student)obj = obj as Student
            Student other = obj as Student;
            return this.StudentId == other.StudentId;
        }
    }
}
