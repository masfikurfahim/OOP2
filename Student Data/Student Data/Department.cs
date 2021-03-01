using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Data
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Student[] students;
        int studentCount;

        public Department(string name)
        {
            this.name = name;
            students = new Student[50];
        }

        public void AddStudent(params Student[] stu)
        {
            foreach (Student s in stu)
            {
                students[studentCount++] = s;
                s.Dept = this;
            }
        }

        public void PrintStudent()
        {
            foreach (Student s in students)
                if (s != null)
                    s.ShowInfo();
        }
    }
}

