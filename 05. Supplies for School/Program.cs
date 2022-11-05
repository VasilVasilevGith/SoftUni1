namespace _05._Supplies_for_School
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double chemicals = 5.80;
            double markers = 7.20;
            double Preparation = 1.20;

            int chemicalsSum = int.Parse(Console.ReadLine());
            int markersSum = int.Parse(Console.ReadLine());
            int preparationSum = int.Parse(Console.ReadLine());
            int discount1 = int.Parse(Console.ReadLine());

            int discountCalculate = (discount1 / 100) * 100;

            Console.WriteLine(discountCalculate);
        }
    }
}