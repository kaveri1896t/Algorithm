// --------------------------------------------------------------------------------------------------------------------
// <copyright file="utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>  
    /// class utility contains multiple methods which has logic to give solutions
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Calculate day of week on given date
        /// </summary>
        /// <param name="d">entered day</param>
        /// <param name="m">entered month</param>
        /// <param name="y">entered year</param>
        /// <returns>integer associated with day of week</returns>
        public static int Dayofweek(int d, int m, int y)
        {
            int y0, d0, m0, x;
            y0 = y - ((14 - m) / 12);
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = m + (12 * ((14 - m) / 12)) - 2;
            d0 = (d + x + (31 * m0 / 12)) % 7;
            return d0;
        }

        /// <summary>
        /// Print array of strings
        /// </summary>
        /// <param name="arr">array of strings</param>
        public static void PrintArray(string[] arr)
        {
            int n = arr.Length;
            foreach (string i in arr)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine();
        }
        
        /// <summary>
        /// Temperature Celsius to Fahrenheit	
        /// </summary>
        /// <param name="temp">temperature in Celsius</param>
        public static void CalcFTemp(double temp)
        {
            double ftemp;
            ftemp = (temp * 9 / 5) + 32;
            Console.WriteLine("Temperature from celsius to Fahrenheit : " + ftemp);
        }

        /// <summary>
        /// Temperature (Fahrenheit to Celsius)	
        /// </summary>
        /// <param name="temp">temperature in Fahrenheit</param>
        public static void CalcCTemp(double temp)
        {
            double ctemp;
            ctemp = (temp - 32) * 5 / 9;
            Console.WriteLine("Temperature from Fahrenheit to  celsius: " + ctemp);
        }

        /// <summary>
        /// Calculate Square root of number using Newton Method
        /// </summary>
        /// <param name="c">double number</param>
        public static void CalSqrtNewton(double c)
        {
            ////relative error tolerance
            double epsilon = 1e-15;
            ////estimate of the square root of c
            double t = c;
            //// repeatedly apply Newton update step until desired precision is achieved
            while (Math.Abs(t - (c / t)) > epsilon * t)
            {
                t = ((c / t) + t) / 2.0;
            }
            //// print out the estimate of the square root of c
            Console.WriteLine("The square root of given number is : ");
            Console.WriteLine(t);
        }

        /// <summary>
        /// To check whether two strings are Anagram or not
        /// </summary>
        /// <param name="s1">Takes first array  of characters</param>
        /// <param name="s2">Takes second array of characters</param>
        public void StringAnagram(char[] s1, char[] s2)
        {
            ////Calculating length of arrays
            int n1 = s1.Rank;
            int n2 = s2.Rank;
            bool flag = false;
            ////Compare lengths of both arrays 
            ////If equal then only the strings will be Anagram
            if (n1 == n2)
            {
                Array.Sort(s1);
                Array.Sort(s2);
                for (int i = 0; i < n1; i++)
                {
                    ////Compare the array elements
                    if (s1[i] == s2[i])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            else
            {
                flag = false;
            }

            if (flag == true)
            {
                Console.WriteLine("Strings are anagram.");
            }
            else
            {
                Console.WriteLine("Strings are not anagram.");
            }
        }

        /// <summary>
        /// Prime numbers
        /// </summary>
        /// <param name="n">Prime numbers up to n</param>
        /// <returns>ArrayList of prime numbers</returns>
        public ArrayList PrimeNo(int n)
        {
            int i, number;
            bool flag = false;
            ArrayList arr = new ArrayList();
            ////Traverse the list upto n
            for (number = 1; number <= n; number++)
            {
                flag = false;
                for (i = 2; i <= number / 2; i++)
                {
                    ////Check if Number is divisible by multiple numbers
                    if (number % i == 0)
                    {
                        flag = true;

                        break;
                    }
                }
                ////If prime then add it to ArrayList
                if (flag == false && number > 1)
                {
                    arr.Add(number);
                }
            }
            ////Return list of prime numbers
            return arr;
        }

        /// <summary>
        /// Binary search for integers
        /// </summary>
        /// <param name="arr">Array of random numbers</param>
        /// <param name="first">Index of first number</param>
        /// <param name="last">Index of last number</param>
        /// <param name="key">Key to search in array</param>
        public void BinarySearch(int[] arr, int first, int last, int key)
        {
            int mid = (first + last) / 2;

            while (first <= last)
            {
                ////compare key with mid element
                if (arr[mid] == key)
                {
                    Console.WriteLine(key + " is found at index: " + mid + 1);
                    break;
                }
                else if (key > arr[mid])
                {
                    ////search in right subarray
                    first = mid + 1;
                }
                else
                {
                    ////search in left subarray
                    last = mid - 1;
                }

                mid = (first + last) / 2;
            }
            ////check if the element is not in both half
            if (first > last)
            {
                Console.WriteLine("Element is not found!");
            }
        }

        /// <summary>
        /// Binary search for String
        /// </summary>
        /// <param name="arr">Array of random strings</param>
        /// <param name="first">Index of first string</param>
        /// <param name="last">Index of last string</param>
        /// <param name="key">Key to search in array</param>
        public void BinaryString(string[] arr, int first, int last, string key)
        {
            int mid = (first + last) / 2;
            while (first <= last)
            {
                int res = key.CompareTo(arr[mid]);
                if (res == 0)
                {
                    Console.WriteLine("Element is found at index: " + (mid + 1));
                    break;
                }
                else if (res < 0)
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }

                mid = (first + last) / 2;
            }

            if (first > last)
            {
                Console.WriteLine("Element is not found!");
            }
        }

        /// <summary>
        /// Bubble sort for integers
        /// </summary>
        /// <param name="arr">array of integers</param>
        /// <param name="len">length of array</param>
        /// <returns>sorted array</returns>
        public int[] BubbleSort(int[] arr, int len)
        {
            ////Traverse each array element
            foreach (int i in arr)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        ////swap the elements 
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            ////return sorted array
            return arr;
        }

        /// <summary>
        /// Bubble sort for strings
        /// </summary>
        /// <param name="str">array of strings</param>
        /// <param name="len">length of array</param>
        /// <returns>sorted array</returns>
        public string[] BubbleSortString(string[] str, int len)
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (str[j].CompareTo(str[i]) < 0)
                    {
                        ////swap the elements
                        string temp = str[j];
                        str[j] = str[i];
                        str[i] = temp;
                    }
                }
            }
            ////returns sorted array
            return str;
        }

        /// <summary>
        /// Insertion sort for integers
        /// </summary>
        /// <param name="arr">array of integers</param>
        public void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                ////compare from current index upto 0th index
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        ////swap the elements
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Insertion sort for strings
        /// </summary>
        /// <param name="str">array of strings</param>
        public void InsertionString(string[] str)
        {
            int n = str.Length;
            ////compare from current index upto 0th index
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (str[j - 1].CompareTo(str[j]) > 0)
                    {
                        string temp = str[j - 1];
                        str[j - 1] = str[j];
                        str[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Merge sort for Strings
        /// </summary>
        /// <param name="arr">array of strings</param>
        /// <param name="l">left index</param>
        /// <param name="m">middle index</param>
        /// <param name="r">right index</param>
        public void Merge(string[] arr, int l, int m, int r)
        {
            ////Calculate length of two subarrays
            int n1 = m - l + 1;
            int n2 = r - m;
            string[] left = new string[n1];
            string[] right = new string[n2];
            ////move strings from left of mid in L subarray
            for (int i = 0; i < n1; i++)
            {
                left[i] = arr[l + i];
            }
            ////move strings from right of mid in R subarray
            for (int j = 0; j < n2; j++)
            {
                right[j] = arr[m + 1 + j];
            }
            ////Merge the temporary arrays
            int p = 0, n = 0;
            //// Initial index of merged sub array array 
            int k = l;
            while (p < n1 && n < n2)
            {
                if (left[p].CompareTo(right[n]) < 0)
                {
                    arr[k] = left[p];
                    p++;
                }
                else
                {
                    arr[k] = right[n];
                    n++;
                }

                k++;
            }
            //// Copy remaining elements of L[] if any 
            while (p < n1)
            {
                arr[k] = left[p];
                p++;
                k++;
            }
            ////Copy remaining elements of R[] if any */
            while (n < n2)
            {
                arr[k] = right[n];
                n++;
                k++;
            }
        }

        /// <summary>
        /// Sort function to divide array in sub arrays
        /// </summary>
        /// <param name="arr">array of strings</param>
        /// <param name="l">left index</param>
        /// <param name="r">right index</param>
        public void Sort(string[] arr, int l, int r)
        {
            if (l < r)
            {
                //// Find the middle point 
                int m = (l + r) / 2;
                //// Sort first and second halves 
                this.Sort(arr, l, m);
                this.Sort(arr, m + 1, r);
                //// Merge the sorted halves 
                this.Merge(arr, l, m, r);
            }
        }

        /// <summary>
        /// Print array of integers
        /// </summary>
        /// <param name="arr">array of integers</param>
        public void PrintIntArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Vending Machine to return certain amount 
        /// </summary>
        /// <param name="change">Amount to return</param>
        public void CalcNotes(int change)
        {
            ////Currency in array
            int[] arr = new int[] { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            ////n_notes for no of notes of each currency & min_notes for no of minimum notes
            int n_notes, min_notes = 0;
            while (change > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    n_notes = change / arr[i];
                    change = change % arr[i];
                    min_notes += n_notes;
                    Console.WriteLine("No of " + arr[i] + " rupees notes : " + n_notes);
                }
            }

            Console.WriteLine("\n\nMinimum number of notes : " + min_notes);
        }

        /// <summary>
        /// Calculate Monthly Payment 
        /// </summary>
        public void MonthlyPayments()
        {
            //// take input principle amount,
            Console.WriteLine("Enter the principle amount");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year");
            double year = Convert.ToDouble(Console.ReadLine());
            //// takes input from user for interest 
            Console.WriteLine("Enter the interest");
            double rate = Convert.ToDouble(Console.ReadLine());
            //// intials the valuse 
            double n = 12 * year;
            double r = rate / (12 * 100);
            //// formula for payments 
            double payment = (principle * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("The monthly payment is " + payment);
        }

        /// <summary>
        /// Decimal to binary conversion
        /// </summary>
        /// <returns>String representing Binary number</returns>
        public string DecimalToBinary()
        {
            Console.WriteLine("Enter the number in Decimal : ");
            int dn = Convert.ToInt32(Console.ReadLine());
            string binaryNum = string.Empty;
            while (dn != 0)
            {
                int rem = dn % 2;
                binaryNum = binaryNum + rem;
                dn = dn / 2;
            }

            Console.WriteLine("Binary Conversion of number is : ");
            return binaryNum;
        }
    }
}