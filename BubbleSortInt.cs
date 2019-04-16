// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BubbleSortInt.cs" company="Bridgelabz">
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
 /// /Bubble sort for Integer
 /// </summary>
 public class BubbleSortInt
 {
  /// <summary>
  /// Initializes a new instance of the <see cref="BubbleSortInt"/> class.
  /// </summary>
  public BubbleSortInt()
  {
   try
   {
    Utility u = new Utility();
    int n;
    Console.WriteLine("Enter the value of n : ");
    n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    Console.WriteLine("Enter the array elements : ");
    for (int i = 0; i < n; i++)
    {
    arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    arr = u.BubbleSort(arr, n);
    Console.WriteLine("Sorted array is :");
    for (int i = 0; i < n; i++)
     {
      Console.WriteLine(arr[i] + " ");
     }
    }
    catch (Exception ex)
    {
    Console.WriteLine(ex.Message);
    }
  }
 }
}
