namespace zadacha_3
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = 2.54;
            int  sm =int.Parse(Console.ReadLine()); 
            double fainal = sm * inch;
            Console.WriteLine(fainal);
        }
    }
}