namespace _07._Food__Delivery
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Пилешко меню –  10.35 лв. 
            //Меню с риба – 12.40 лв.
            //Вегетарианско меню  – 8.15 лв.

            int chikenVaule = int.Parse(Console.ReadLine());
            int fishVaule = int.Parse(Console.ReadLine());
            int veganVaule = int.Parse(Console.ReadLine());

            double priceMenu = chikenVaule * 10.35;
            double priceMenu1 = fishVaule * 12.45;
            double priceMenu2 = veganVaule * 8.15;

            var price1 = priceMenu + priceMenu1 + priceMenu2;

            Console.WriteLine(price1);
            //var price2 = price1 * 0.18;
            

        }
    }
}