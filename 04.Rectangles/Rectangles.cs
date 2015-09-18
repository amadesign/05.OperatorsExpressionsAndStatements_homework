namespace _04.Rectangles
{
    using System;

    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double p = 2 * (width + hight);
            double a = width * hight;
            Console.WriteLine("Perimeter: {0}, Area: {1}", p, a);
            
        }
    }
}
