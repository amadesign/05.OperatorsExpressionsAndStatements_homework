namespace _03.DivideBySevenAndFive
{
    using System;

    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            bool nDevided = (n % 7 == 0 && n % 5 == 0) ?true : false;
            Console.WriteLine(nDevided);
        }
    }
}
