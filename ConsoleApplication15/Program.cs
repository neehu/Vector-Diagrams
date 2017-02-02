using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VectorDiagrams
{
    class Shapes
    {
        class Circle
        {
            public int radius;
            public Circle()
            {
            }
            public Circle(int radius)
            {
                this.radius = radius;
            }
        }

        class Square
        {
            private int width;
            public Square()
            {
            }
            public Square(int width)
            {
                this.width = width;
            }
        }

        class Ellipse
        {
            private int horizontal, vertical;
            public Ellipse()
            {
            }
            public Ellipse(int horizontal, int vertical)
            {
                this.horizontal = horizontal;
                this.vertical = vertical;
            }
        }

        class Rectangle
        {
            private int width, height;
            public Rectangle()
            {
            }
            public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        class TextBox
        {
            private int width, height;
            public TextBox()
            {
            }
            public TextBox(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        static void display(int xPosition, int yPosition, int width, int height, string userInput)
        {
            Console.SetCursorPosition(xPosition, yPosition);
            Console.WriteLine("{0} is with {1}x{2} size", userInput, width, height);
        }

        static void Main(string[] args)
        {
            int xPosition, yPosition, width, height;
            Console.WriteLine("Enter the location");
            xPosition = Convert.ToInt32(Console.ReadLine());
            yPosition = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the shape to be added");
            Console.WriteLine("Rectangle,Circle,Square,TextBox,Ellipse");
            string userinput = Console.ReadLine();
            if (userinput == ("Rectangle"))
            {

                Console.WriteLine("Enter the width and height");
                width = (Convert.ToInt32(Console.ReadLine()));
                height = (Convert.ToInt32(Console.ReadLine()));
                Rectangle shape = new Rectangle(width, height);
                display(xPosition, yPosition, width, height, userinput);
            }

            if (userinput == "Circle")
            {

                Console.WriteLine("Enter the radius");
                width = (Convert.ToInt32(Console.ReadLine()));
                Circle shape1 = new Circle(width);
                display(xPosition, yPosition, width, 0, userinput);
            }

            if (userinput == "Square")
            {

                Console.WriteLine("Enter the width");
                height = (Convert.ToInt32(Console.ReadLine()));
                Square shape2 = new Square(height);
                display(xPosition, yPosition, 0, height, userinput);
            }

            if (userinput == "Ellipse")
            {

                Console.WriteLine("Enter the Horizontal and vertical lengths");
                width = (Convert.ToInt32(Console.ReadLine()));
                height = (Convert.ToInt32(Console.ReadLine()));
                Ellipse ellipse = new Ellipse(height, width);
                display(xPosition, yPosition, width, height, userinput);
            }

            if (userinput == "TextBox")
            {

                Console.WriteLine("Enter the width and height lengths");
                width = (Convert.ToInt32(Console.ReadLine()));
                height = (Convert.ToInt32(Console.ReadLine()));
                TextBox textbox = new TextBox(height, width);
                display(xPosition, yPosition, width, height, userinput);
            }

            Console.ReadKey();
        }
    }
}

