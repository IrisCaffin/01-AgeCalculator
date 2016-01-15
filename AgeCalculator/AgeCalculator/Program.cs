using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //User needs to be asked for birthday information
            Console.WriteLine("Enter your birthdate (MM/DD/YYYY): ");
            //Read and define birthday information given
            string birthday = Console.ReadLine();
            //Establish what LocalDateTime is (PCT)
            Instant now = SystemClock.Instance.Now;
            //User birthday input (MM/DD/YYYY) needs to be converted to days (day= highest datetime unit of time) with Parse
            LocalDateTime birthDays = LocalDateTime(birthday);
            //Figure out today's date and name it
            LocalDateTime dateToday = LocalDateTime.Today;
            //Figure out the difference between today's date and the user's birthdate
            TimeSpan difference = dateToday.Subtract(birthDays);
            //Convert timespan into decimal format (taking total number of days and converting with Double to decimal)
            double totalDays = difference.Days;

            //Convert number of total days of user's birthdate into years (forward slash is divide symbol) 365.25 incl leapyear
            double yearsTotal = totalDays / 365;
            double actualYears = Math.Floor(yearsTotal);

            double monthsTotal = (totalDays / 365) / 12;
            double actualMonths = Math.Floor(monthsTotal);

            double weeksTotal = ((totalDays / 365) % 12) / 4;
            double actualWeeks = Math.Floor(weeksTotal);

            double daysTotal = (((totalDays / 365) % 12) % 4) / 7;
            double actualDays = Math.Floor(daysTotal);

            //Age results (years, weeks, and days) needs to be returned to user
            Console.WriteLine("Your age in years, months, weeks, and days: ");
            Console.WriteLine("Years: " + actualYears);
            Console.WriteLine("Months: " + actualMonths);
            Console.WriteLine("Weeks: " + actualWeeks);
            Console.WriteLine("Days: " + actualDays);

            Console.ReadLine();


           
        }
    }
}
