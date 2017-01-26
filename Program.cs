using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace ConsoleApplication6
{
    class Shapes
    {
        public class Rectangle
        {
            private int width, height;
            public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        public class Circle
        {
            private int width;
            public Circle(int width)
            {
                this.width = width;
                
            }
        }

        public class Ellipse
        {
            private int width;
            public Ellipse(int width)
            {
                this.width = width;

            }
        }
        public class Square
        {
            private int width;
            public Square(int width)
            {
                this.width = width;

            }
        }


        static void display(int x, int y, int width, int height, string user)
        {
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < x; j++)
                {
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("{0} is with {1}x{2} size", user, width, height);
        }

        static void Main(string[] args)
        {
            int x, y, width, height;
            Console.WriteLine("Enter the location");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the shape to be added");
            Console.WriteLine("Rectangle,Circle,Square");
            string userinput = Console.ReadLine();
            if (userinput == "Rectangle")
            {

                Console.WriteLine("Enter the width and height");
                width = (Convert.ToInt32(Console.ReadLine()));
                height = (Convert.ToInt32(Console.ReadLine()));
                Rectangle shape = new Rectangle(width, height);
                display(x, y, width, height, userinput);
            }

            if (userinput == "Circle")
            {

                Console.WriteLine("Enter the width");
                width = (Convert.ToInt32(Console.ReadLine()));
                Circle shape1 = new Circle(width);
                display(x, y, width, 0, userinput);
            }

            if (userinput == "Square")
            {

                Console.WriteLine("Enter the width");
                height = (Convert.ToInt32(Console.ReadLine()));
                Square shape2 = new Square(height);
                display(x, y, 0, height, userinput);
            }

            Console.ReadKey();

        }
    }
}
