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


        static void display(int xPosition, int yPosition, int width, int height, string userinpuut)
        {
            for (int index = 0; index < yPosition; index++)
            {
                Console.WriteLine("");
                for (int counter = 0; counter < xPosition; counter++)
                {
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("{0} is with {1}x{2} size", userinpuut, width, height);
        }

        static void Main(string[] args)
        {
            int xposition, yposition, width, height;
            Console.WriteLine("Enter the location");
            xposition = Convert.ToInt32(Console.ReadLine());
            yposition = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the shape to be added");
            Console.WriteLine("Rectangle,Circle,Square");
            string userinput = Console.ReadLine();
            if (userinput == "Rectangle")
            {

                Console.WriteLine("Enter the width and height");
                width = (Convert.ToInt32(Console.ReadLine()));
                height = (Convert.ToInt32(Console.ReadLine()));
                Rectangle shape = new Rectangle(width, height);
                display(xposition, yposition, width, height, userinput);
            }

            if (userinput == "Circle")
            {

                Console.WriteLine("Enter the width");
                width = (Convert.ToInt32(Console.ReadLine()));
                Circle shape1 = new Circle(width);
                display(xposition, yposition, width, 0, userinput);
            }

            if (userinput == "Square")
            {

                Console.WriteLine("Enter the width");
                height = (Convert.ToInt32(Console.ReadLine()));
                Square shape2 = new Square(height);
                display(xposition, yposition, 0, height, userinput);
            }

            Console.ReadKey();

        }
    }
}
