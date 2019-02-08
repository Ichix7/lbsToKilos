using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG_210_Assignment_3
{
    class Program
    {
        ///Program should Change weight from "Kilos" to "Lbs"
        static void Main(string[] args)
        {

            String weight = "";

            do
            {
                Console.WriteLine("Please input weight in Lbs");
                weight = Console.ReadLine();

                Console.WriteLine("Your weight in  kilo's is: {0}", ConvertToKilograms(weight));
                CleanScreen();
                
            } while (weight != "q");
         }


        public static double ConvertToKilograms(string weight)
        {
            double weightInKilos = 0.453592;
            double weightInLbs = Convert.ToDouble(weight);

            return weightInKilos * weightInLbs;
        }

        static public void CleanScreen()
        {
            Console.WriteLine("<Press Enter>");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
