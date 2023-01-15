using System;

namespace Time___15min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int time = (hours * 60 + minutes) + 15;
            int hoursform = time / 60;
            int minutesform = time % 60;

            if (hoursform == 24)
            {
                Console.WriteLine($"0:{minutesform:d2}");
            }
            else
            {
                Console.WriteLine($"{hoursform}:{minutesform:d2}");
            }
        }
    }
}
