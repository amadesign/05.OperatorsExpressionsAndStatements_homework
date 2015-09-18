namespace _05.ThirdDigitIsSeven
{
    using System;

    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool check = (n / 100) % 10 == 7;
            Console.WriteLine("{0}", check); 
        }
    }
}
