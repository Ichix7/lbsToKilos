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

            //loop with exit command

            //Request weight from user

            //Call function - input is user answer

            //return answer
            
        }


        public char ConvertToKilograms(int x)
        {
            // tester method will use finish variable for do while loop
            char finish = 'n';
            // variable to loop in this method to check if user wants to repeat
            string repeat = "";
            // conversion from pound to kilograms
            int answer = x / 2;
            answer = answer - (answer / 10);


            Console.Clear();
            Console.WriteLine("*****Pounds to Kilograms Converter*****");

            // do loop to see if user wants to end program or repeat from beginning
            do
            {
                Console.WriteLine("\n{0} Pounds is {1} Kilograms. \nWould you like to convert another number? Enter y/n", x, answer);
                repeat = Console.ReadLine().ToLower();

                if (repeat == "y")
                {
                    repeat = "n";
                    Console.Clear();
                    return finish;
                }
                if (repeat == "n")
                {
                    finish = 'y';
                    return finish;
                }
                else
                {
                    Console.WriteLine("\nNot a valid response, please enter either a 'y' or 'n'. \nPress Enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (repeat != "n");

            return finish;
        }

    }
}
