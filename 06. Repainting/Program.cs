namespace _06._Repainting
{
    using System;
    internal class Program
    {
        //Предпазен найлон - 1.50 лв.за кв.метър
        //Боя - 14.50 лв.за литър
        //Разредител за боя - 5.00 лв.за литър

        /*За всеки случай, към необходимите материали, Румен иска да добави още 10% от количеството
        боя и 2 кв.м. найлон, разбира се и 0.40 лв. за торбички. Сумата, която се заплаща на
        майсторите за 1 час работа, е равна на 30% от сбора на всички разходи за материали.*/
        static void Main(string[] args)
        {
            //това че  от конзолата
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            // това са  цените на нещата
            double nylonPrice = 1.50;
            double paintPrice = 14.50;
            double thinnerPrice = 5.00;
            //решение
            double nylonReh=(nylon + 2) * nylonPrice;
            double paintReh = (paint + 0.10) * paintPrice;
            double thinnerReh = thinner * thinnerPrice;

            double reshen = nylonReh + paintReh + thinnerReh + 0.40 ;

            Console.WriteLine(nylonReh);
            Console.WriteLine(paintReh);
            Console.WriteLine(thinnerReh);
            Console.WriteLine(reshen + 15.45);

        }
    }
}