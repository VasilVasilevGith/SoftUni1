namespace _04._Toy_Shop
{
    using System;
    internal class Program
    {
      
        static void Main(string[] args)
        {

            //цени в  магазина

            double puzle = 2.60;
            double talkingDoll = 3;
            double teddyBear = 4.10;
            double minion = 8.20;
            double truck = 2;

            //Конзолата  чете 

            double excursion = double.Parse(Console.ReadLine());
            int puzleNumber = int.Parse(Console.ReadLine());
            int talkingDollNumber = int.Parse(Console.ReadLine());
            int teddyBearNumber = int.Parse(Console.ReadLine());
            int minionNumber = int.Parse(Console.ReadLine());
            int truckNumber = int.Parse(Console.ReadLine());

            //преснятания 

            double puzleMoney=puzle * puzleNumber;
            double talkingDollMoney= talkingDoll * talkingDollNumber;
            double teddyBearMoney= teddyBear * talkingDollNumber;
            double minionMoney= minion * minionNumber;
            double truckMoney= truck * truckNumber;

            // събиране  на  парите  // наем 

            double endPrice = puzleMoney + talkingDollMoney + teddyBearMoney + minionMoney + truckMoney;
            double rent = endPrice * 0.10;
            Console.WriteLine(endPrice);
            Console.WriteLine(rent);
            // проверки 
            

        }
    }
}