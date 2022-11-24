using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Figure
    {
        private double perimeterfigure;
        public double Perimeter { get { return perimeterfigure; } set { this.perimeterfigure = value; } }

        private string FigureShape;
        enum figureshape
        {
            triangle,
            rectangle,
            pentagon
        }

        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;
        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            FigureShape = figureshape.triangle.ToString();
            Console.WriteLine(FigureShape);
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            FigureShape = figureshape.rectangle.ToString();
            Console.WriteLine(FigureShape);
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            FigureShape = figureshape.pentagon.ToString();
            Console.WriteLine(FigureShape);
        }

        public static double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = Perimeter;
            if (FigureShape == figureshape.triangle.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, C) + LengthSide(B, C);
                return perimeter;
            }
            else if (FigureShape == figureshape.rectangle.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, D) + LengthSide(B, C) + LengthSide(C, D);
                return perimeter;
            }
            else if (FigureShape == figureshape.pentagon.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, E) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E);
                return perimeter;
            }
            return perimeter;
        }

    }
}
