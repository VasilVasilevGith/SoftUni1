namespace _07._Projects_Creation_1
{
    using System;
    internal class Program
    {
        // 3 chasa 
        //"The architect {името на архитекта} will need
        //{необходими часове} hours to complete {брой на проектите} project/s."
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int pro = int.Parse(Console.ReadLine());
            int hours = pro * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {pro} project/s.");
        }
    }
}