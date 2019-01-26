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
            Console.WriteLine("Enter any key to continue:");
            Console.ReadKey(true);

            // Self Reflection: As I am new to programming in c#, got good understanding of flow control statements and nested loops and the syntax.
            //Got to know more about the scope of the variables while working on the functions.Also, I found its easy to write the code once i complete the pseudocode.
            // Writing code is easy once we create a blueprint of it by working on algorithm
            //learnt that, to get double as output by performing calculation on two integers, we need to parseusing (double)
            //Got better understanding on when to use whil,for and foreach
            //Working with few problem statements, like creating triangle was fun.
            //
            //Recommendations: I felt, exercise should make us use more inbuilt functions and libraries so that we are well aware of them.
             



           
           } //edof main

        private static void printPrimeNumbers(int min,int max)
        {

            try
            {
                Console.Write("Prime numbers between {0} and {1} are: ", min, max);
                for (int num = min; num <= max; num++) //iteration on the range provided
                {

                    Boolean flag = true; //flag set to true for prime numbers
                    for (int iter1 = num / 2; iter1 >= 2; iter1--) //check if each number in range is divisible from 2 to number/2
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
                Console.WriteLine("");
                double result = 0;//variabe to store series result
               // Console.WriteLine(fact(n));
                for (int i = 1; i < n; i++) // iteration from 1 to number provided
                {
                    if (i % 2 != 0)//if condition for odd terms
                    {
                        result = result + (fact(i) / (i + 1.0)); //to get result as double, added 1.0
                    }
                    else //for even terms
                    {
                        result = result - (fact(i) / (i + 1.0)); //to get result as double, added 1.0
                    }

                }//edof for 
                int result_dec = (int)(result*1000); //rounding off to 3 decimals
                result = (double)result_dec/1000;//rounding off to 3 decimals
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
                int factorial = 1; //variable to store factorial result
                while (num > 1) //loop to calculate factorial of num
                {
                    factorial = factorial * num;
                    num--;
                }//edof while
                return factorial;
            }//edof try
            catch
            {
                Console.WriteLine("Exception occured while computing fact()");
            }//edof catch
            return 0;

        }//edof fact

        public static long decimalToBinary(long n)
        {
            try
            {
                long number = n; //decima number provided
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

            }//edof try
                catch
            {
                Console.WriteLine("Exception occured while computing decimaltoBinary");
            }//edof catch
            return 0;
        } //edof decimaltoBinary

        public static long binaryToDecimal(long n)
        {
            try
            {
                long var1; //variable to store quotient
                long result=0; //variable to store decial result
               
                for(int i=0;n!=0;i++)
                {
                    var1 = n % 10;
                    result = (long)(result + (var1 * Twopower(i)));
                    n = n / 10;
                   }//edof for

                return result;


            }//edof try
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }//edof catch
            return 0;




        }//edof binaryToDecimal
        
        
        public static void printTriangle(int n)
        {
            try
            {
                int z = 1;
                for (int i = n; i >= 1; i--) 
                {
                    
                    for (int j = 1; j <= i; j++) //for loop for adding spaces
                    {
                        Console.Write(" ");
                    }//edof for iter j
                    for (int k = 1; k <= (2*z)-1;k++)//for loop for adding *'s
                    {
                        Console.Write("*");
                        
                    }//edof for iter k
                    z++;
                    
                  //  Console.Write("");
                    Console.WriteLine(" ");
                }//edof iter i
            }//edof try
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }//edof catch
        }

        public static void computeFrequency(int[] a)
        {


            try {
                int[] element_dist = new int[a.Length]; //array to store distinct elements from the input array
                int count = 0;
                int length = 0;
                Console.WriteLine("Number   Frequency");
                foreach (int i in a) //iterating over the array a
                {

                    if (!element_dist.Contains(i))// check if value from a is present in array element_dist
                    {


                        count = 0;
                        foreach (int j in a)
                        {


                            if (i == j)
                            {
                                count++; //variable to store the frequency of the individual values 

                            }//edof if

                        }//for each iter j
                        element_dist[length] = i;
                        Console.WriteLine("{0}          {1}", i, count);
                        length++;
                    }//edof if
                }//edof for each iter i


            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            

        }//edof catch
        }//edof computeFrequency method

        public static int Twopower(int n) //method to calulate powers of 2
        {
            try
            {
                int exp = 1; //variable to store result
                for (int i = 0; i < n; i++)
                {
                    exp = exp * 2; 
                }//edof for
                return exp;
            }//edof try
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            } //edof catch
            return 0;
        }
    }//edof class



}


