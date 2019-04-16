// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToBinary.cs" company="Bridgelabz">
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
    /// Decimal to binary
    /// </summary>
    public class ToBinary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToBinary"/> class.
        /// </summary>
        public ToBinary()
        {
         try
         {
                Utility u = new Utility();
                Console.WriteLine(u.DecimalToBinary());
         }
         catch (Exception ex)
         {
                Console.WriteLine(ex.Message);
         }
        }
    }
}
