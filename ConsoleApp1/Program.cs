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

            circle1.Draw();
            shape1.Draw();

            Console.ReadLine();
        }
    }
}
