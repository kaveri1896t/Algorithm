// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuestionGame.cs" company="Bridgelabz">
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
/// Question Game 
/// </summary>
public class QuestionGame
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionGame"/> class.
        /// </summary>
        public QuestionGame()
        {
        int[] arr = new int[] { 2, 255, 1, 9, 250, 4, 3, 117, 27, 54, 10, 43, 72, 189 };
        char ch;
        int first = 0, last = arr.Length - 1;
        Console.WriteLine("Keep one number in your mind from the below list: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\nEnter 1 if you are done with it.....");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 1)
        {
            Array.Sort(arr);
            while (first <= last)
            {
                    int mid = (first + last) / 2;
                    Console.WriteLine("Is your number less than or equal to " + arr[mid] + "?(y/n) : ");
                    ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'y' || ch == 'Y')
                    {
                    last = mid;
                    Console.WriteLine("Is " + arr[mid] + " your number?(y/n) : ");
                    ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'y' || ch == 'Y')
                    {
                    Console.WriteLine("Thank you for playing this game...");
                    break;
                    }
                    }
                    else
                    {
                    first = mid;
                    Console.WriteLine("Is " + arr[mid] + " your number?(y/n) : ");
                    ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'y' || ch == 'Y')
                    {
                    Console.WriteLine("Thank you for playing this game...");
                    break;
                    }
                    }

                    mid = (first + last) / 2;
            }
        }
        else
        {
        Console.WriteLine("You have entered wrong input. Exiting....");
        }
        }
    }
}
