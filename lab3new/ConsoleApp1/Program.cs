using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new();
            Console.WriteLine("enter the first side:");
            rectangle.Firstside = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the second side");
            rectangle.Secondside = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter and area:");
            Console.WriteLine($"Perimeter{rectangle.Perimiter}");
            Console.WriteLine($"Area:{rectangle.Area}");
        }
    }
}
