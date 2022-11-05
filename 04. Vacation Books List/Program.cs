namespace _04._Vacation_Books_List
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int paperAll = int.Parse(Console.ReadLine());
            int paperPerHour = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            int finalHours = paperAll / paperPerHour;

            int total = finalHours / day;
            Console.WriteLine(total);
        }
    }
}