namespace _07.PointInACircle
{
    using System;

    class PointInACircle
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            bool InCircle = (((x*x) + (y*y)) <= 2*2);
            Console.WriteLine(InCircle);
        }
    }
}
