using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minimum and maximum numbers using comma seperated values");
            string numbers = Console.ReadLine();
            string[] num_array = numbers.Split(',');

            try
            {

                while (int.Parse(num_array[0]) > int.Parse(num_array[1])) //while loop to check if user passed numbers in increasing order
                {
                    Console.WriteLine("Please enter lowest first and greatest number later");
                    numbers = Console.ReadLine();
                    num_array = numbers.Split(',');
                }// edof while loop
                int num_min = int.Parse(num_array[0]);
                int num_max = int.Parse(num_array[1]);

                isPrime(num_min, num_max); //function call
                //Console.ReadKey(true);
            } //edof try
            catch
            {
                Console.WriteLine("Error occured");
            } //edof catch
            Console.ReadKey(true);
           } //edof main

        private static void isPrime(int min,int max)
        {

            Console.Write("Prime numbers between {0} and {1} are: ", min, max);
            for (int num = min; num <= max; num++)
            {

                Boolean flag = true;
            for (int iter1 = num / 2; iter1 >= 2; iter1--)
            {

                if (num % iter1 == 0)
                {
                   // Console.WriteLine("number" + num.ToString() + "is not prime");
                    flag = false;
                    break;
                } //edof if
            }//edof for with iter1

            if (flag)
            {
                Console.Write(num.ToString() + " ");
            }//edof if
            }// edof for with num 
        }
    }
}


