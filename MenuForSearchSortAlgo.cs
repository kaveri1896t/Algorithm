// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuForSearchSortAlgo.cs" company="Bridgelabz">
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
    /// Menu for Sort and search algorithms
    /// </summary>
    public class MenuForSearchSortAlgo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuForSearchSortAlgo"/> class.
        /// </summary>
        public MenuForSearchSortAlgo()
        {
        char condition;
        do
        {
         Console.WriteLine("Press 1 for : Bubble sort for Integer Array");
         Console.WriteLine("Press 2 for : Bubble sort for String Array");
         Console.WriteLine("Press 3 for : Insertion sort for Integer Array");
         Console.WriteLine("Press 4 for : Insertion sort for String Array");
         Console.WriteLine("Press 5 for : Binary search for Integer Array");
         Console.WriteLine("Press 6 for :Binary search for String Array");
         int ch = Convert.ToInt32(Console.ReadLine());
         switch (ch)
         {
         case 1:
            BubbleSortInt bsi = new BubbleSortInt();
            break;
         case 2:
            BubbleSortString bss = new BubbleSortString();
            break;
         case 3:
            InsertionSortInt iis = new InsertionSortInt();
            break;
         case 4:
            InsertionSortString iss = new InsertionSortString();
            break;
         case 5:
            BinarySearchInt bi = new BinarySearchInt();
            break;
         case 6:
            BinarySearchString bs = new BinarySearchString();
            break;
         default:
            break;
        }

        Console.WriteLine("enter Y to search or sort more / N to exit");
        condition = Convert.ToChar(Console.ReadLine());
        }
        while (condition == 'y');
        return;
        }
    }
}
