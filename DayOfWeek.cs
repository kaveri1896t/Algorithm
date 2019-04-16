// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
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
    /// Day on the given Date
    /// </summary>
    public class DayOfWeek
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DayOfWeek"/> class.
        /// </summary>
        public DayOfWeek()
        {
            try
            {
                int day = 0, month = 0, year = 0, n = 0;
                do
                {
                    Console.WriteLine("Enter the day (dd) : ");
                    day = Convert.ToInt32(Console.ReadLine());
                }
                while (day > 31 || day < 1);

                do
                {
                    Console.WriteLine("Enter the month (mm) : ");
                    month = Convert.ToInt32(Console.ReadLine());
                }
                while (month > 12 || month < 1);

                do
                {
                    Console.WriteLine("Enter the year (yyyy) : ");
                    year = Convert.ToInt32(Console.ReadLine());
                }
                while (year < 1000 || year > 9999);

                n = Utility.Dayofweek(day, month, year);
                Console.WriteLine(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
