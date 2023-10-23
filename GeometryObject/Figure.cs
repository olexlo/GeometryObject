using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryObject
{
    internal class Figure
    {
        public string Name_Figure { get; set; }
        public int AmoutSides { get; set; }
        
        public Figures(string name_Figure, int amoutSides)
        {
            Name_Figure = name_Figure;
            AmoutSides = amoutSides;
        }
    }
    internal class Polygon : Figure
    {
        public double[] Sides { get; set; }
        public Polygons (AmoutSides)
        {
            Sides = new double[AmoutSides];
        }

        public void SetSides()
        {
            for (int i = 0; i < Sides.Length; i++)
            {
                Console.Write($"Введіть довжину сторони {i + 1}: ");
                Sides[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public static double Perimeter(double a)
        {
            return a * 4;
        }
        public static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }
    }
    internal class Radius : Figure 
    {

    }
    internal class Circle : Radius
    {
    }
    internal class Ellipse : Radius 
    {
    }
    internal class Parallelepiped : Polygon 
    {
        public static double Perimeter(Sides)
        {
            double a;
            for (int i = 0; i < Sides.Length; i++)
            {
                a =+ Sides[i];
            }
            return a;
        }

    }
    internal class Square : Parallelepiped 
    {
    }
    internal class Trapezoid : Parallelepiped 
    {
    }
    internal class Polyhedron : Parallelepiped 
    {
    }
    internal class Triagle : Polygon 
    {

    }
}
