// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqrtNewtonMethod.cs" company="Bridgelabz">
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
    /// Square root of a number
    /// </summary>
    public class SqrtNewtonMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqrtNewtonMethod"/> class.
        /// </summary>
        public SqrtNewtonMethod()
        {
            try
            {
                Console.WriteLine("Enter the number : ");
                double c = Convert.ToDouble(Console.ReadLine());
                Utility.CalSqrtNewton(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
     }
}