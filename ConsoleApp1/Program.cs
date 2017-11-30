using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var shape1 = new Shape();

            shape1.X = 10;
            shape1.Y = 20;
            shape1.Widht = 100;
            shape1.Height = 50;

            var circle1 = new Circle();

            circle1.X = 20;
            circle1.Y = 10;
            circle1.Widht = 100;
            circle1.Height = 300;

            var square1 = new Square();

            square1.X = 420;
            square1.Y = 420;
            square1.Widht = 420;
            square1.Height = 420;

            var triangle1 = new Triangle();

            triangle1.X = 25;
            triangle1.Y = 26;
            triangle1.Widht = 62;
            triangle1.Height = 16;


            //triangle1.Draw();
            //circle1.Draw();
            //shape1.Draw();
            //square1.Draw();

            var shapes = new List<Shape>();
            shapes.Add(shape1);
            shapes.Add(circle1);
            shapes.Add(square1);
            shapes.Add(triangle1);

            foreach (var i in shapes)
            {
                i.Draw();
            }


            Console.ReadLine();
        }
    }
}
