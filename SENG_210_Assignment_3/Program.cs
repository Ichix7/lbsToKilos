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
            char finish = 'n';
            string repeat = "";
            int answer = x / 2;
            answer = answer - (answer / 10);
            Console.Clear();
            Console.WriteLine("*****Pounds to Kilograms Converter*****");
            return finish;
        }

    }
}
