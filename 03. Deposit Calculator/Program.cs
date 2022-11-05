namespace _03._Deposit_Calculator
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double depozit = Double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());

            double suma = depozit + srok * ((depozit * lihva / 100) / 12);

            Console.WriteLine(suma);
        }
    }
}