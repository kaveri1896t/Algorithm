// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchString.cs" company="Bridgelabz">
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
/// Binary search for string
/// </summary>
public class BinarySearchString
{
 /// <summary>
 /// Initializes a new instance of the <see cref="BinarySearchString"/> class.
 /// </summary>
 public BinarySearchString()
 {
  try
  {
   Utility u = new Utility();
   Console.WriteLine("Enter the number of strings : ");
   int n = Convert.ToInt32(Console.ReadLine());
   string[] str = new string[n];
   Console.WriteLine("Enter the strings: ");
   for (int i = 0; i < n; i++)
   {
    str[i] = Console.ReadLine();
   }

   Console.WriteLine("Enter the number of strings : ");
   string key1 = Console.ReadLine();
   int f = 0, l = str.Length;
   u.BinaryString(str, f, l, key1);
  }
  catch (Exception ex)
  {
   Console.WriteLine(ex.Message);
  }
 }
 }
}
