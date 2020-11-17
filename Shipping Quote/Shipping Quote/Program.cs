using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            int packageweightlimit = 50;
           
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", please enter the package weight:");
            int currentPackageweight = Convert.ToInt32(Console.ReadLine());

            if (currentPackageweight > packageweightlimit){
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
                

            else
            {
                Console.WriteLine("Please enter the package Height:");
                int currentPackageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package width:");
                int currentPackageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int currentPackageLength = Convert.ToInt32(Console.ReadLine());

                int currentDimensions = currentPackageHeight + currentPackageLength + currentPackageWidth;
                if (currentDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                else
                {
                    int currentQuote = currentPackageHeight * currentPackageLength * currentPackageWidth * currentPackageweight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + currentQuote);
                }
            }

            Console.ReadLine();

         


            


        }

    }
}
