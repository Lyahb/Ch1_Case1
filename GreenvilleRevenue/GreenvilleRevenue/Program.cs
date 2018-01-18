using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GreenvilleRevenue
{
    class GreenvilleRevenue
    {
        static void Main()
        {
            string lastYearString, currentYearString;
            int last = 0, current = 0, amount = 0;
            Write("Enter the number of contestants in last year's competition...");
            lastYearString = ReadLine();
            last = Convert.ToInt32(lastYearString);
            Write("Enter the number of contestants for this year's competition...");
            currentYearString = ReadLine();
            current = Convert.ToInt32(currentYearString);
            WriteLine("The number of contestants in last year's competition is {0}.", last);
            WriteLine("The number of contestants in this year's competition is {0}.", current);
            amount = current * 25;
            WriteLine("The amount of money made from this year's entrance fees is ${0}", amount);
            bool lastYear = current > last;
            WriteLine("It is {0} that more people competed this year then last year.", lastYear);
        }
    }
}
