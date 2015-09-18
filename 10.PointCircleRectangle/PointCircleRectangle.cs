namespace _10.PointCircleRectangle
{
    using System;

    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float radius = 1.5f;
            float sum = (x * x + y * y);
            float multiply = radius * radius;
            bool isInside = sum <= multiply && y > 0;
            if (isInside)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            
        }
    }
}
