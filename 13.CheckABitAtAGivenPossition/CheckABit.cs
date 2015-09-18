namespace _13.CheckABitAtAGivenPossition
{
    using System;

    class CheckABit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit:");
            int p = int.Parse(Console.ReadLine());
            int nRightP = n >> p;
            int bit = nRightP & 1;
            bool check = bit == 1;
            Console.WriteLine(check);
        }
    }
}
