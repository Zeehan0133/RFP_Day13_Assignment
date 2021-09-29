using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Assignment
{
    class UC4_Find_Maximum
    {
        public static int  Find_Maximum(int firstValue,int secondValue,int thirdValue,int fourthValue)
        {


            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 )
            { 
            
          
                Console.WriteLine("Greatest number is " + firstValue);
            }
            
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 )
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
