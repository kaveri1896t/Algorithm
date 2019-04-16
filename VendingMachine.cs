using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class VendingMachine
    {
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
