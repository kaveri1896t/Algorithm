// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchInt.cs" company="Bridgelabz">
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
 /// Binary search for Integer
 /// </summary>
 public class BinarySearchInt
 {
 /// <summary>
 /// Initializes a new instance of the <see cref="BinarySearchInt"/> class.
 /// </summary>
 public BinarySearchInt()
 {
  try
  {
   Utility u = new Utility();
   Console.WriteLine("Enter the number of elements : ");
   int n = Convert.ToInt32(Console.ReadLine());
   int[] arr = new int[n];
   Console.WriteLine("Enter the elements : ");
   for (int i = 0; i < n; i++)
   {
   arr[i] = Convert.ToInt32(Console.ReadLine());
   }

   Console.WriteLine("Entered Array elements are : ");
   for (int i = 0; i < n; i++)
   {
    Console.WriteLine(arr[i] + " ");
   }

   Console.WriteLine("Enter the key to be searched : ");
   int key = Convert.ToInt32(Console.ReadLine());
   int first = 0, last = arr.Length;
   u.BinarySearch(arr, first, last, key);
  }
  catch (Exception ex)
  {
   Console.WriteLine(ex.Message);
  }
 }
 }
}
