using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public Triangle()
        {
            Console.WriteLine("\nTriangle Class\n");
        }

        public void ShowInfo()
        {
            Console.WriteLine("The value of x is: " + x);
            Console.WriteLine("The value of y is: " + y);
            Console.WriteLine("The value of z is: " + z);
            Console.WriteLine("The Triangle is: " + TestTriangle());
        }

        private string TestTriangle()
        {
            if (x == y && x == z)
                return "Equilateral";
            else if (x == y || x == z || y == z)
                return "Isosceles";
            else
                return "Scalene";
        }

        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public int Z
        {
            set
            {
                z = value;
            }
            get
            {
                return z;
            }
        }
    }
}