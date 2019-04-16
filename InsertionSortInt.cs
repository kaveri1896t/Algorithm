// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSortInt.cs" company="Bridgelabz">
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
    /// Class insertion sort
    /// </summary>
    public class InsertionSortInt
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertionSortInt"/> class.
        /// </summary>
        public InsertionSortInt()
        {
            try
            {
                Utility u = new Utility();
                int n;
                Console.WriteLine("Enter the value of n : ");
                n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine("Enter the array elements : ");
                ////Take the Integer elements
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                u.InsertionSort(arr);
                Console.WriteLine("sorted array is:");
                for (int i = 0; i < arr.Length; i++)
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
