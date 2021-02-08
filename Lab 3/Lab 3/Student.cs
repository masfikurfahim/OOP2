using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student()
        {
            Console.WriteLine("\nStudent Class\n");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Department: " + department);
            Console.WriteLine("Student CGPA: " + cgpa);
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Department
        {
            set
            {
                department = value;
            }
            get
            {
                return department;
            }
        }
        public float CGPA
        {
            set
            {
                cgpa = value;
            }
            get
            {
                return cgpa;
            }
        }

    }
}
