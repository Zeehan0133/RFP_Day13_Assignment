using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Assignment
{
    class UC1Maximum_Num
    {
       public static void Maximum_Num()
        {
            
            int firstValue = 5;
           
            int secondValue = 6;
           
            int thirdValue = 5;


            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("Greatest number is " + firstValue);
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("Greatest number is " + secondValue);
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                Console.WriteLine("Greatest number is " + thirdValue);
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }


    }
}
