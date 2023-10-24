namespace GeometryObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped parallelepiped = new Parallelepiped();
            parallelepiped.PrintFigure("Периметр", parallelepiped.Perimeter());
            parallelepiped.PrintFigure("Площа", parallelepiped.Area());

            Circle circle = new Circle();
            circle.PrintFigure("Периметр", circle.Perimeter());
            circle.PrintFigure("Площа", circle.Area());
        }
    }
}