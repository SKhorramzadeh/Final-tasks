using System;

namespace Test1       //Identification
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please Enter your name");
            name=Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            
            string strAge;
            int age;
            Console.WriteLine("Please Enter your Age");
            strAge = Console.ReadLine();
            age = int.Parse(strAge);
            if (age<15 || age>120)       // !=not ||=or
            {
                Console.WriteLine("Your Age must be between 15 and 120");
            }
            else
            {
                Console.WriteLine($"Your Age is {strAge}");
            }
            Console.WriteLine("Please Enter your Age");
            for (; ; )                 // for(int i=0 ; i<= j ; i++)
            {
                strAge = Console.ReadLine();
                age = int.Parse(strAge);
                if (age >= 15 && age <= 120)
                {
                    Console.WriteLine($"Your Age is {strAge}");
                    break;
                }
                Console.WriteLine("Your Age must be between 15 and 120; Enter again");
            }

            string strPhoneNumber;
            long intPhoneNumber;
            Console.WriteLine("Please Enter your Phone Number");
            strPhoneNumber = Console.ReadLine();

            while (true)
            {
                if (strPhoneNumber.Length==11)
                    break;
                Console.WriteLine("Phone Number must have 11 digit; try again");
                strPhoneNumber = Console.ReadLine();
            }

            do
            {
                if (strPhoneNumber.StartsWith("0"))
                    break;
                Console.WriteLine("Phone Number must start by 0; try again");
                strPhoneNumber = Console.ReadLine();

            } while (true);

            bool digit = true;
            while (digit)
            {
                try
                {
                    intPhoneNumber = long.Parse(strPhoneNumber);
                    digit = false;
                }
                catch   //(Exception)
                {
                    Console.WriteLine("Phone Number must just countain digits; try again");
                    strPhoneNumber = Console.ReadLine();
                    //throw;
                }
            }
        }
    }
}
