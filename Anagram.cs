// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Anagram.cs" company="Bridgelabz">
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
 /// String Anagram
 /// </summary>
 public class Anagram
 {
  /// <summary>
  /// Initializes a new instance of the <see cref="Anagram"/> class.
  /// </summary>
  public Anagram()
  {
   try
   {
    string str;
    char[] s1, s2;
    Console.WriteLine("Enter first string : ");
    str = Console.ReadLine();
    s1 = str.ToCharArray();
    Console.WriteLine("Enter second string : ");
    str = Console.ReadLine();
    s2 = str.ToCharArray();
    Utility u = new Utility();
    u.StringAnagram(s1, s2);
    }
    catch (Exception ex)
    {
     Console.WriteLine(ex.Message);
    }
  }
 }
}