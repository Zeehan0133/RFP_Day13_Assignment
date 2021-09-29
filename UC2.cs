using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Assignment
{
    class UC2_Floats_Maximum
    {
        public static void Maximum()
        {
            float firstValue = 6.1f;
            float secondValue = 7.0f;
            float thirdValue = 6.5f;



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
