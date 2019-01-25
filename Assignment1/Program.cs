using System;
using System.Linq;

namespace Assignment1_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);


            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

//self reflection


           
           } //edof main

        private static void printPrimeNumbers(int min,int max)
        {

            try
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
            }//edof try

            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");

            }//edof catch
        }//edof print primes

        public static double getSeriesResult(int n)
        {

            try
            {
                double result = 0;
                Console.WriteLine(fact(n));
                for (int i = 1; i < n; i++)
                {
                    if (i % 2 != 0)//if condition for odd terms
                    {
                        result = result + (fact(i) / (i + 1.0)); //to get result as double, added 1.0
                    }
                    if (i % 2 == 0) //if condition for even terms
                    {
                        result = result - (fact(i) / (i + 1.0)); //to get result as double, added 1.0
                    }

                }//edof for 
                int result_dec = (int)(result*1000); //rounding off to 3 decimals
                Console.WriteLine(result_dec);
                result = (double)result_dec/1000;
                return result;


            }//edof try

            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }//edof catch

            return 0;
        }//edof getSeriesResult

        private static int fact(int num)
        {
            // throw new NotImplementedException();
            try
            {
                int factorial = 1;
                while (num > 1)
                {
                    factorial = factorial * num;
                    num--;
                }
                return factorial;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing fact()");
            }
            return 0;

        }

        public static long decimalToBinary(long n)
        {
            try
            {
                long number = n;
                long binary = 0; //variable to store the result
                int count = 1;
                long var1 = 0; //variable for quotient
                while (number != 0)
                {

                    var1 = number % 2;
                    number = number / 2;
                    binary = binary + var1 * count;
                    count = count * 10;
                }//edof while
                return binary;

            }//dof try
                catch
            {
                Console.WriteLine("Exception occured while computing decimaltoBinary");
            }
            return 0;
        } //edof decimaltoBinary

        public static long binaryToDecimal(long n)
        {
            try
            {
                long var1;
                long result=0;
                int exp = 1;
                while (n != 0)
                {
                    var1 = n % 10;
                    result = (long)(result + (var1 * exp));
                    n = n / 10;
                    exp=exp*2;

                 }

                return result;


            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            return 0;




        }//edof binaryToDecimal
        
        
        public static void printTriangle(int n)
        {
            try
            {
                int z = 1;
                for (int i = n; i >= 1; i--)
                {
                    
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= (2*z)-1;k++)
                    {
                        Console.Write("*");
                        
                    }
                    z++;
                    
                  //  Console.Write("");
                    Console.WriteLine(" ");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {


            try {
                int[] element_dist = new int[a.Length];
                int count = 0;
                int length = 0;
                Console.WriteLine("Number   Frequency");
                foreach (int i in a)
                {

                    if (!element_dist.Contains(i))
                    {


                        count = 0;
                        foreach (int j in a)
                        {


                            if (i == j)
                            {
                                count++;

                            }

                        }
                        element_dist[length] = i;
                        Console.WriteLine("{0}          {1}", i, count);
                        length++;
                    }
                }


            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            

        }
    }
    }//edof class



}


