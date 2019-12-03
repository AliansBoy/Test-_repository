using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int arbuzi = 10;
            //int barani = 15;
            //int crocodili = default;

            //Console.WriteLine($"a: {arbuzi}, b: {barani}, c: {crocodili}");

            //if (RefOutExample(a, ref b, out c))
            //{
            //    Console.WriteLine("Succesed");
            //}
            //else
            //{
            //    Console.WriteLine("Not Succesed");
            //}

            //Console.WriteLine((RefOutExample(arbuzi, ref barani, out crocodili)) ? "Succesed" : "Not Succesed");

            //Console.WriteLine($"a: {arbuzi}, b: {barani}, c: {crocodili}");
            //Console.ReadKey();

            //while (!int.TryParse(Console.ReadLine(), out int input) || input < 0)
            //{

            //}

            var pointa = new Point(1.0m, 1.0m);
            var pointb = new Point(0m, 0m);

            Console.WriteLine("Initial points: ");
            Console.WriteLine($"point A: {pointa.x}, {pointa.y}");
            Console.WriteLine($"point B: {pointb.x}, {pointb.y}");

            MovePoint(ref pointa, 2, 1);
            MovePoint(ref pointb, 1, 2);

            Console.WriteLine("Moved Points: ");
            Console.WriteLine($"point A: {pointa.x}, {pointa.y}");
            Console.WriteLine($"point B: {pointb.x}, {pointb.y}");

            Console.ReadKey();


        }

        //static bool RefOutExample (int a, ref int b, out int c)
        //{
        //    c = b * a;
        //    a = a * 10;
        //    b = c - a;

        //    return (a > c);
        //}
        private static void MovePoint (ref Point p, decimal distanceX = 0, decimal distanceY = 0)
        {
            p.x += distanceX;
            p.y += distanceY;
        }

        public struct Point
        {
            public decimal x;
            public decimal y;

            public Point (decimal x, decimal y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
