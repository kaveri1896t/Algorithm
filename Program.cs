// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
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
    /// class program 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method where execution starts
        /// </summary>
        /// <param name="args">String array</param>
        public static void Main(string[] args)
        {
            char condition;
            do
            {
                Console.WriteLine("Press  1 for : String Anagram");
                Console.WriteLine("Press  2 for : Prime Numbers upto N");
                Console.WriteLine("Press  3 for : Prime Palindromic Anagram Numbers");
                Console.WriteLine("Press  4 for : Menu for Search and Sort");
                Console.WriteLine("Press  5 for : Game of Guessing the number");
                Console.WriteLine("Press  6 for : BinarySearch to search word from file");
                Console.WriteLine("Press  7 for : Insertion sort for String Array");
                Console.WriteLine("Press  8 for : Bubble sort for Integer Array");
                Console.WriteLine("Press  9 for : Merge Sort for String");
                Console.WriteLine("Press 10 for : Vending Machine");
                Console.WriteLine("Press 11 for : Day Of the week of entered date");
                Console.WriteLine("Press 12 for : Temperature Conversion");
                Console.WriteLine("Press 13 for : Monthly Payment");
                Console.WriteLine("Press 14 for : Square Root using Newton Method");
                Console.WriteLine("Press 15 for : Convert number to Binary");
                try
                {
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Anagram a = new Anagram();
                            break;
                        case 2:
                            Prime p = new Prime();
                            break;
                        case 3:
                            PalPrimeAnagram p1 = new PalPrimeAnagram();
                            break;
                        case 4:
                            MenuForSearchSortAlgo mss = new MenuForSearchSortAlgo();
                            break;
                        case 5:
                            QuestionGame qg = new QuestionGame();
                            break;
                        case 6:
                            ReadFromFile rf = new ReadFromFile();
                            break;
                        case 7:
                            InsertionSortString in1 = new InsertionSortString();
                            break;
                        case 8:
                            BubbleSortInt bbi = new BubbleSortInt();
                            break;
                        case 9:
                            MergeString ms = new MergeString();
                            break;
                        case 10:
                            VendingMachine vm = new VendingMachine();
                            break;
                        case 11:
                            DayOfWeek dow = new DayOfWeek();
                            break;
                        case 12:
                            Temperature t = new Temperature();
                            break;
                        case 13:
                            MonthlyPayment mp = new MonthlyPayment();
                            break;
                        case 14:
                            SqrtNewtonMethod sq = new SqrtNewtonMethod();
                            break;
                        case 15:
                            ToBinary tb = new ToBinary();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("enter Y for Main Menu / N to exit");
                condition = Convert.ToChar(Console.ReadLine());
            }
            while (condition == 'y');
        }
    }
}
