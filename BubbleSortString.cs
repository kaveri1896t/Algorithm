// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BubbleSortString.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

 /// <summary>
 /// Bubble sort for string
 /// </summary>
    public class BubbleSortString
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BubbleSortString"/> class.
        /// </summary>
        public BubbleSortString()
        {
            try
            {
                Utility u = new Utility();
                int n;
                Console.WriteLine("Enter the value of n : ");
                n = Convert.ToInt32(Console.ReadLine());
                string[] arr = new string[n];
                Console.WriteLine("Enter the strings : ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Console.ReadLine();
                }

                arr = u.BubbleSortString(arr, n);
                Console.WriteLine("Sorted array is :");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            catch (Exception ex)
            {
             Console.WriteLine(ex.Message);
            }
        }
    }
}
