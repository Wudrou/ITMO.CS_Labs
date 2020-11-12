using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_WhatDay
{
    class WhatDay
    {
        enum MonthName
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a day number between 1 and 365: ");
                string line = Console.ReadLine();
                int dayNum = int.Parse(line);

                if(dayNum < 1 || dayNum >365)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                List<int> DaysInMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum = dayNum - daysInMonth;
                        monthNum++;
                    }
                }

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            }

            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
            
            Console.ReadKey();
        }
    }
}
