// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeString.cs" company="Bridgelabz">
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
    /// Merge sort for string
    /// </summary>
    public class MergeString
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeString"/> class.
        /// </summary>
        public MergeString()
        {
            try
            {
                int n;
                Console.WriteLine("Enter number of strings : ");
                n = Convert.ToInt32(Console.ReadLine());
                string[] arr = new string[n];
                Utility u = new Utility();
                Console.WriteLine("Enter strings : ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Console.ReadLine();
                }

                Console.WriteLine("\nGiven Array : ");
                Utility.PrintArray(arr);
                u.Sort(arr, 0, arr.Length - 1);    
                Console.WriteLine("\nSorted array : ");
                Utility.PrintArray(arr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
