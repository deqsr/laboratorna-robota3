using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>
            {
                new Point(x: 8, y: 16, "A"),
                new Point(x: 16, y: 24, "B"),
                new Point(x: 12, y: 18, "C"),
                new Point(x: 9, y: 16, "D"),
                new Point(x: 14, y: 21, "E")
            };
            Figure triangle = new(points[0], points[1], points[2]);
            Console.WriteLine(triangle.PerimeterCalculator());
            Figure rectangle = new(points[0], points[1], points[2], points[3]);
            Console.WriteLine(rectangle.PerimeterCalculator());
            Figure pentagon = new(points[0], points[1], points[2], points[3], points[4]);
            Console.WriteLine(pentagon.PerimeterCalculator());
        }
    }
}
