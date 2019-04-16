// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
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
    /// Vending machine returns number of notes
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendingMachine"/> class.
        /// </summary>
        public VendingMachine()
        {
            try
            {
                Utility u = new Utility();
                int change;
                Console.WriteLine("Enter the change in ruppes to be returned by Vending Machine : ");
                change = Convert.ToInt32(Console.ReadLine());
                u.CalcNotes(change);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
