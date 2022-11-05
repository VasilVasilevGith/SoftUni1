namespace password_guess
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var FurstTime = int.Parse(Console.ReadLine());
            var SecondTime = int.Parse(Console.ReadLine());
            var ThirdTime = int.Parse(Console.ReadLine());

            int totalTime = FurstTime + SecondTime + ThirdTime;

            int minutes = totalTime / 60;
            int second = totalTime % 60;
            if (minutes < 10)
            {
                if (second < 10)
                {
                    Console.WriteLine($"{minutes}:0{second}");
                }
                else
                {
                    Console.WriteLine($"{minutes}:{second}");
                }
            }
            else if (minutes >= 10)
            {
                Console.WriteLine($"{minutes}:{second}");
            }
        }
    }
}