namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double pens = 5.80;
            double markers = 7.20;
            double detergentL = 1.20;
            double pensCount = double.Parse(Console.ReadLine());
            double markersCount = double.Parse(Console.ReadLine());
            double detergentCount = double.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());
            double suma = pens * pensCount + markers * markersCount + detergentL * detergentCount;
            double discount = discountPercent / 100;
            double finalPrice = suma - (suma * discount);
            Console.WriteLine(finalPrice);
        }
    }
}