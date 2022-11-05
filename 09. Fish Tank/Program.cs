namespace _09._Fish_Tank
{
    using System;
    internal class Program
    {
        /*  1.	Дължина в см – цяло число в интервала [10 … 500]Length
            2.	Широчина в см – цяло число в интервала [10 … 300] Width
            3.	Височина в см – цяло число в интервала [10… 200]Height
            4.	Процент  – реално число в интервала [0.000 … 100.000]Percentage
        */

        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());

            double lengthWidthHeight = length * width * weight;
            double lengthWidthHeight1 = lengthWidthHeight / 1000;

            Console.WriteLine(lengthWidthHeight1 * );
        }
    }
}