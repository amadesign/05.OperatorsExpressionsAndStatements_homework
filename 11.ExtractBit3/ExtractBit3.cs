namespace _11.ExtractBit3
{
    using System;

    class ExtractBit3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine(bit);
        }
    }
}
