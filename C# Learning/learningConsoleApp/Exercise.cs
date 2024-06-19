using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace learningConsoleApp
{
    public class Exercise
    {
        public void Table()
        {
            Console.Write("Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num*i);
            }
        }



        public void FizzBuzz()
        {
            bool threeDiv = false, fiveDiv = false;

            for (int i = 1; i <= 15; i++)
            {
                threeDiv = i%3 == 0;
                fiveDiv = i%5 == 0;
                if(threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }



        public void ReverseStr()
        {
            Console.Write("Enter Your String: ");
            string msg = Console.ReadLine();
            for (int i = msg.Length-1; i >= 0; i--)
            {
                Console.Write(msg[i]);
            }
            Console.WriteLine();
        }



        public void PasswordChecker()
        {
            Console.Write("Enter Password: ");
            string pswd = Console.ReadLine();
            Console.Write("Enter Password Again: ");
            string pswd2 = Console.ReadLine();
            
            if(!pswd.Equals(string.Empty)) {
                if(!pswd2.Equals(string.Empty))
                {
                    if(pswd.Length >= 6 && pswd2.Length >=6)
                    {
                        if(pswd.Equals(pswd2))
                        {
                            Console.WriteLine("Passwords Matched!");
                        }
                        else
                        {
                            Console.WriteLine("Passwords don't match!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter password again!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password!");
            }

            Console.WriteLine();
        }



        public void TriangleValidation()
        {
            int[] arr = new int[3];
            int angleSum = 0;
            for(int i=1; i<=arr.Length; i++)
            {
                Console.Write($"Enter Angle {i}: ");
                angleSum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");
        }



        public void EvenOddSplit()
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.Write("Even Numbers are: ");
            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }
            Console.Write(Environment.NewLine + "Odd Numbers are: ");
            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }
        }



        public static void ArrayOfMultiples()
        {
            int num = 10;
            int len = 10;
            int[] arr = new int[len];
            for (int i = 1; i <= len; i++)
            {
                arr[i - 1] = num * i;
            }
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }



        public void IntArrSum()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int total = 0;
            if(arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    total += arr[i];
                }
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine("The array is Empty!");
            }
        }
        
        

        public void ExceptionHandling()
        {
            bool looping = true;
            while(looping)
            {
                try
                {
                    Console.Write("Enter Number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);
                    looping = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter the number within the valid range");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter only numbers");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error is: {e.Message}");
                }
            }
        }




    }
}
