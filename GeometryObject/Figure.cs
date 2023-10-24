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
        /// <summary>
        /// name - Назва фігури, amout - Кількість унікальних сторін
        /// </summary>
        /// <param name="name_Figure"> Назва фігури</param>
        /// <param name="amoutSides"> Кількість унікальних сторін</param>
        public Figure (string name_Figure, int amoutSides)
        {
            Name_Figure = name_Figure;
            AmoutSides = amoutSides;
        }
    }
    internal class Polygon : Figure
    {
        
        public double[] Sides { get; set; }
        
        public Polygon(string name, int numberOfSides):base(name, numberOfSides)
        {
            Sides = new double[numberOfSides];
            for ( int i = 0; i < Sides.Length; i++)
            {
                Console.Write($"Введіть довжину сторони {i + 1} {name}: ");
                Sides[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public static double Perimeter(double a)
        {
            return a * 4;
        }
        }

        public void PrintFigure(string math_operation,double result) 
        {
    }
    internal class Radius : Figure 
    {

    }
    internal class Circle : Radius
    {
    }
    }
    internal class Parallelepiped : Polygon 
    {
        public Parallelepiped():base("Parallelepiped",2) 
        {
        }        
        public double Perimeter()
        {
            double a=0;
            for (int i = 0; i < Sides.Length; i++)
            {
                a =+ Sides[i];
            }
            return a;
        }
    }
    internal class VolumeParallel : Parallelepiped 
    {
    }
    }
}
