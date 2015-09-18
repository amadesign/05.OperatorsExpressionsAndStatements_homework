namespace _02.GravitationOnTheMoon
{
    using System;

    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double count = weight * 17/100;
            Console.WriteLine(count);
        }
    }
}
