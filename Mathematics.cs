using System;

namespace Test2           //Mathematics (Divisiblity, Sorting)
{
    class Program
    {
        //A method to find the lowest number in an array (with 2 private outputs).
        public static (int, int) minVal(int n, int[] ary)
        {
            int minValue = ary[0];
            int minID = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ary[j] < minValue)
                    {
                        minValue = ary[j];
                        minID = j;
                    }
                }
            }
            return (minValue, minID);
        }

        //A method to find the bigest number in an array .
        public static int maxVal(int n, int[] ary)
        {
            int maxValue = ary[0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ary[j] > maxValue)
                    {
                        maxValue = ary[j];
                    }
                }
            }
            return maxValue;
        }

        //check if 2 digits are divisible or not?
        static void Main(string[] args)
        {
            string strNum;
            int num1;
            int num2;
            double rest;
            Console.WriteLine("Please Enter 2 digits to check if they are divisible or not?");
            strNum = Console.ReadLine();
            num1 = int.Parse(strNum);
            strNum = Console.ReadLine();
            num2 = int.Parse(strNum);
            if (num1 > num2)
                rest = num1 % num2;
            else
                rest = num2 % num1;
            if (rest == 0)
                Console.WriteLine($"{num1} & {num2} are divisible");
            else
                Console.WriteLine($"The rest of dividion of {num1} & {num2} is {rest}");

            //Sorting an array.
            string str;
            int nDigits;
            Console.WriteLine("Please Enter an aray to sort its argumants");
            Console.WriteLine("First Enter number of your digits");
            str = Console.ReadLine();
            nDigits = int.Parse(str);
            int[] array1 = new int[nDigits];
            int[] array2 = new int[nDigits];

            for (int i = 0; i < nDigits; i++)       // Read array
            {
                str = Console.ReadLine();
                array1[i] = int.Parse(str);
                array2[i] = array1[i];
            }
            int maximum = maxVal(nDigits, array1);  //Find Max
            for (int i = 0; i < nDigits; i++)      //Find min
            {
                (int minimum, int mID) = minVal(nDigits, array1);
                array2[i] = minimum;
                array1[mID] = maximum;
            }
            for (int i = 0; i < nDigits; i++)     //Print
            {
                Console.WriteLine($" {i} , {array2[i]}");
            }
        }
    }
}
