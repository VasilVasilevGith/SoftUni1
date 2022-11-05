namespace _08._Pet_Shop
{
    using System;
    internal class Program
    {
        //кучета е на цена 2.50 лв, а опаковка храна за котки струва 4 лв.
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double cat = 4;
            double dog = 2.50;
            double totalSumDog = dogFood * dog;
            double totalSumCat = catFood * cat;
            double totalSum = totalSumDog + totalSumCat;
            Console.WriteLine($"{totalSum} lv.");


        }
    }
}