using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student 
    {
        private static int nextStudentId = 1;
        private string Name { get; set; }
        private int StudentId { get; set; }
        private int NumberOfCredits { get; set; } = 0;
        private double Gpa { get; set; } = 0.0;

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }
        public Student(string name, int studentId): this(name, studentId, 0, 0) { }

        public Student(string name): this(name, nextStudentId)
        {
            nextStudentId++;
        }
    }
}
