using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_AreaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c1 = new Circle(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(c1.getArea());

            double[] dimentions = Console.ReadLine().Split().Select(X => Convert.ToDouble(X)).ToArray();
            Rectangle R1 = new Rectangle(dimentions[0], dimentions[1]);
            Console.WriteLine(R1.getArea());

            Circle c2 = new Circle(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(c2.getArea());

            Square s1 = new Square(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(s1.getArea());

            dimentions = Console.ReadLine().Split().Select(x => Convert.ToDouble(x)).ToArray();
            Rectangle R2 = new Rectangle(dimentions[0], dimentions[1]);
            Console.WriteLine(R2.getArea());

        }
    }

    abstract class Shape//this abstract Shape class is our base class to inherit from
    {//abstract classes are created by using the 'abstract' keyword
        public abstract int getArea();
        /*abstract classes may or may not have abstract  functions/fields, in this case we'll make an abstract function called getArea, and please look closely at the syntax in C#, if you're doing  Java it can be different.*/
    }
    //we have a subclass called Square with its own unique characteristics, it inherits from Shape
    class Square : Shape
    {
        private int length;
        private int width;
        private double v;

        public Square() { }//empty constructor

        public Square(double v)
        {
            this.v = v;
        }

        public Square(int length, int width)//overloading, we will pass in a length & width
        {
            this.length = length;
            this.width = width;
        }
        public override int getArea()//pay close attention here: any functions inherited from an abstract or virtual class MUST contain the 'override' keyword
        {
            int area = (int)Math.Round(this.v * this.v);
            return area;//and must return the same type
        }
    }
    //the same routine is done for the next classes that inherit from Shape
    class Triangle : Shape
    {
        private int baseLength;
        private int height;
        public Triangle() { }
        public Triangle(int baseLength, int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }
        public override int getArea()
        {
            int area = this.baseLength * this.height / 2;
            return area;
        }
    }
    class Circle : Shape
    {
        private double radius;
        public Circle() { }
        public Circle(double r)
        {
            this.radius = r;
        }
        public override int getArea()
        {
            int area = (int)Math.Round((Math.Pow(this.radius, 2) * Math.PI));
            return area;
        }
    }

    class Rectangle : Shape
    {
        private int length;
        private int width;
        private double v1;
        private double v2;

        public Rectangle() { }//empty constructor
        public Rectangle(int length, int width)//overloading, we will pass in a length & width
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle(double v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override int getArea()//pay close attention here: any functions inherited from an abstract or virtual class MUST contain the 'override' keyword
        {
            int area = (int) Math.Round(this.v1 * this.v2);
            return area;//and must return the same type
        }

    }
}