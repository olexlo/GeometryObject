namespace GeometryObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var a = new Figure("Cu",5);
            Parallelepiped parallelepiped = new Parallelepiped();
            parallelepiped.PrintFigure("Периметр",parallelepiped.Perimeter());
        }
    }
}