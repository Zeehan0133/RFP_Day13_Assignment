using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Assignment
{
    class UC3_String_Maximum
    {
        public static void Maximum()
        {
            string firstString = "apple";
            string secondString = "banana";
            string thirdString = "mango";


            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                Console.WriteLine("Greatest String is "+ firstString);
            }

            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                Console.WriteLine("Greatest String is " + secondString);
            }

            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                Console.WriteLine("Greatest String is " + thirdString);
            }

            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }


    }
    
}
