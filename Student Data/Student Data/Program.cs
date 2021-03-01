using System;

namespace Student_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science");
            Department d2 = new Department("Electrical Engineering");

            Student s1 = new Student("Tanvir", "13245", 2.50);
            Student s2 = new Student("Sabbir", "13246", 3.50);
            Student s3 = new Student("Rahim", "132447", 3.00);
            Student s4 = new Student("Sakib", "132448", 4.00);

            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);
            d2.AddStudent(s4);

            d1.PrintStudent();
            d2.PrintStudent();

            Console.ReadLine();
        }
    }
}