// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalPrimeAnagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Anagram numbers which are Palindromic Prime 
    /// </summary>
    public class PalPrimeAnagram
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PalPrimeAnagram"/> class.
        /// </summary>
        public PalPrimeAnagram()
        {
            try
            {
                int n;
                ////List of prime numbers
                ArrayList list = new ArrayList();
                ////List of Prime Palindrome numbers
                ArrayList list1 = new ArrayList();
                ////List of Prime Palindrome Anagram numbers
                ArrayList list2 = new ArrayList();
                Console.WriteLine("Enter n : ");
                n = Convert.ToInt32(Console.ReadLine());
                list =PrimeNo(n);
                Console.WriteLine("Prime numbers are : ");
                foreach (int j in list)
                {
                    Console.WriteLine(j + " ");
                }

                Console.WriteLine("\nList of prime-palindrome numbers : ");
                foreach (int i in list)
                {
                    if (IsPalindrome(i))
                    {
                        Console.WriteLine(i + " ");
                        list1.Add(i);
                    }
                }

                ////anagram numbers
                foreach (int i in list)
                {
                    foreach (int j in list1)
                    {
                        if (i == j)
                        {
                            list2.Add(i);
                        }
                    }
                }

                Console.WriteLine("\nPrime-Palindrome-anagram numbers are : ");
                foreach (int i in list2)
                {
                    Console.WriteLine(i + " ");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified number is palindrome.
        /// </summary>
        /// <param name="num">The number to be checked.</param>
        /// <returns>Reverse of the given number</returns>
        public static int IsPalin(int num)
        {
            int test = 0;
            try
            {
                while (num != 0)
                {
                    int lastdigit = num % 10;
                    test = (test * 10) + lastdigit;
                    num = num / 10;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return test;
        }

        /// <summary>
        /// Determines whether the specified number is palindrome.
        /// </summary>
        /// <param name="num">The number to check with reverse number</param>
        /// <returns>
        ///   <c>true</c> if the specified number is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsPalindrome(int num)
        {
            return num == IsPalin(num);
        }

        /// <summary>
        /// Primes the no.
        /// </summary>
        /// <param name="n">The range of numbers.</param>
        /// <returns>List of prime numbers</returns>
        public ArrayList PrimeNo(int n)     
        {
            ArrayList list = new ArrayList();

            try
            {
                int i, number;
                bool flag = false;
                for (number = 1; number <= n; number++)
                {
                    flag = false;
                    for (i = 2; i <= number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            flag = true;
                             break;
                        }
                    }

                    if (flag == false && number > 1)
                    {
                        list.Add(number);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }
    }
}