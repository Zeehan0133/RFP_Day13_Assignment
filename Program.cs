UC5 Program.cs
using Generic_Demo;
using System;

namespace UC5_Generic_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int output = Generic_Max_Chk.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double doubleoutput = Generic_Max_Chk.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);
            string strigoutput = Generic_Max_Chk.MaximumStringNumber("22", "33", "44");
            Console.WriteLine(strigoutput);
            int[] intArray = { 112, 344, 432, 555, 678 };
            UC5_Generic_Max<int> generic = new UC5_Generic_Max<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            UC5_Generic_Max<double> genericDouble = new UC5_Generic_Max<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "999" };
            UC5_Generic_Max<string> genericString = new UC5_Generic_Max<string>(stringArray);
            //GenericMaximum<Employee> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadKey();



        }

       
    }
}
using System;


namespace Generic_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

           
                int[] intArray = { 1, 2, 3, 4, 5 };
                double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
                char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
                //Program.toPrint(intArray);
                //Program.toPrint(doubleArray);
                //Program.toPrint(charArray);

                Program.toPrint<int>(intArray);
                Program.toPrint<double>(doubleArray);
                Program.toPrint<char>(charArray);
                Console.ReadKey();
            }

            public static void toPrint<T>(T[] inputArray)
            {
                foreach (var element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            public static void toPrint(int[] inputArray)
            {
                foreach (double element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            public static void toPrint(double[] inputArray)
            {
                foreach (double element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            public static void toPrint(char[] inputArray)
            {
                foreach (char element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("-------------------------------------");
            }
        
    }
}
