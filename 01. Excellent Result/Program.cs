namespace _01._Excellent_Result
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double evaluation = double.Parse(Console.ReadLine());
            if (evaluation >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else if (evaluation <= 5.50)
            {
                Console.WriteLine();
            }
          

        }
    }
}