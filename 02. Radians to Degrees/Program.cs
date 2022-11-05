namespace _02._Radians_to_Degrees
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius =double.Parse(Console.ReadLine());
            double degress = radius * 180 / Math.PI;
            Console.WriteLine(degress);
        }
    }
}