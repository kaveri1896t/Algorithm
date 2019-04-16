// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Temperature.cs" company="Bridgelabz">
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
    /// Temperature Conversion
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        public Temperature()
        {
            try
            {
                Console.WriteLine("Enter the Temperature in Farhenheit : ");
                double ftemp = Convert.ToDouble(Console.ReadLine());
                Utility.CalcCTemp(ftemp);
                Console.WriteLine("Enter the Temperature in Celsius : ");
                double ctemp = Convert.ToDouble(Console.ReadLine());
                Utility.CalcFTemp(ctemp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
