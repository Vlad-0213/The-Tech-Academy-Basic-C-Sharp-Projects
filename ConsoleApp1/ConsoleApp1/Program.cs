using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemperature = 80;
            int roomTemperature = 70;

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }

            else if (roomTemperature > currentTemperature)
                Console.WriteLine("Room temperature is warmer than current temperature.");
            {
                Console.WriteLine("It is not exactly room temperature.");
            }
            Console.ReadLine();
        }

    }
}
