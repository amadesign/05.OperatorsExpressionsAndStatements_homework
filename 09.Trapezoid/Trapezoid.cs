namespace Trapezoid
{
    using System;

    class Trapezoid
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float area = (float)(a + b) / 2 * c;
            Console.WriteLine(area);

        }
    }
}
