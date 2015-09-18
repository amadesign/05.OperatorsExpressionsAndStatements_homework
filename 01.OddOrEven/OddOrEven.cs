namespace _01.OddOrEven
{
    using System;

    class OddOrEven
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result = n % 2 > 0;
            Console.WriteLine(result);
        }
    }
}
