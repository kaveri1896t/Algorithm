// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSortString.cs" company="Bridgelabz">
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
    /// Insertion sort for string
    /// </summary>
    public class InsertionSortString
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertionSortString"/> class.
        /// </summary>
        public InsertionSortString()
        {
            try
            {
                Utility u = new Utility();
                int n;
                Console.WriteLine("Enter the value of n : ");
                n = Convert.ToInt32(Console.ReadLine());
                string[] arr = new string[n];
                Console.WriteLine("Enter the array elements : ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Console.ReadLine();
                }

                u.InsertionString(arr);
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