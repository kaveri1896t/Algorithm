// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadFromFile.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    /// <summary>
    /// Read input from file and sort 
    /// </summary>
    public class ReadFromFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadFromFile"/> class.
        /// </summary>
        public ReadFromFile()
        {
            try
            {
                Utility u = new Utility();
                string text = File.ReadAllText(@"C:\Users\admin\source\repos\BridgeLabz_2019\Algorithm Programs\Algorithm Based Program\Algorithm Based Program\Input.txt");
                string[] words = text.Split(',');
                Console.WriteLine("Strings read from file are : ");
                foreach (string str in words)
                {
                    Console.WriteLine(str + " ");
                }

                Console.WriteLine("Enter search key from above array : ");
                string key = Console.ReadLine();
                int first = 0, last = words.Length - 1;
                u.BinaryString(words, first, last, key);
            }
            catch (Exception ex)
            {
            Console.WriteLine(ex.Message);
            }
        }
    }
}
