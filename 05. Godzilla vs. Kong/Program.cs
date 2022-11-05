namespace _05._Godzilla_vs._Kong
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            // четем  от  конзолата  
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());
            //сметка  за  декора 
            double theDecor = budget * 10 / 100;

            if (extras >= 150)
            {
                double clothingDiscount = clothing * 10 / 100;
                double pedal = extras * clothingDiscount;
                double sum1 = budget - pedal + theDecor;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with");
                Console.WriteLine($"{sum1} leva left.");
            }
            else if 
            {
                double pedal = extras * clothing;
                double sum1 = budget - (pedal + theDecor);
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with");
                Console.WriteLine($"{sum1} leva left.");
            }




        }
    }
}