// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prime.cs" company="Bridgelabz">
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
    /// Prime numbers
    /// </summary>
    public class Prime
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Prime"/> class.
        /// </summary>
        public Prime() 
        {
            try
            {
                Utility u = new Utility();
                ArrayList arr = new ArrayList();
                int n = 0;
                do
                {
                    Console.WriteLine("Enter n (Greater than 2): ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                while (n < 2);
               arr = u.PrimeNo(n);
               foreach (int i in arr)
                {
                    Console.WriteLine(i + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         }
    }
}
