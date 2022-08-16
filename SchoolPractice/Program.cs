using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student emily = new Student("Emily", 1, 1, 4.0);
            Console.WriteLine("The Student class works! " + emily.Name + " is a student!");
        }
    }
}
