namespace _09._Yard_Greening
{
    using System;
    internal class Program
    {
     
        static void Main(string[] args)
        {
            double kvm = double.Parse(Console.ReadLine());
            double price1 = kvm * 7.61;
            double discount = price1 * 0.18;
            Console.WriteLine($"The final price is: {price1 - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}