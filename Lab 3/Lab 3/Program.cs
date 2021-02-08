using System;

namespace Lab_3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Enter Your Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Your ID: ");
            student.ID = Console.ReadLine();

            Console.Write("Enter Your Department: ");
            student.Department = Console.ReadLine();

            Console.Write("Enter Your CGPA: ");
            student.CGPA = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            student.ShowInfo();

           

            Triangle triangle = new Triangle();

            Console.Write("Enter x: ");
            triangle.X = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter y: ");
            triangle.Y = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter z: ");
            triangle.Z = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            triangle.ShowInfo();

            

            Account account = new Account();

            Console.Write("Enter Account Name: ");
            account.AccName = Console.ReadLine();

            Console.Write("Enter Account ID: ");
            account.Acid = Console.ReadLine();

            Console.Write("\nEnter Deposit Amount: ");
            account.Deposit(Convert.ToInt32(Console.ReadLine()));

            Console.Write("\nEnter Withdraw Amount: ");
            account.Withdraw(Convert.ToInt32(Console.ReadLine()));

            

            Course course = new Course();

            Console.Write("Enter Your Course Name: ");
            course.CourseName = Console.ReadLine();

            Console.Write("Enter Your Course Code: ");
            course.CourseCode = Console.ReadLine();

            Console.Write("Enter Your Course Credit: ");
            course.CourseCredit = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            course.ShowCourseInfo();

        }
    }
}
