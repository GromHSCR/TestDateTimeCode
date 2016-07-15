using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDateTimeCode
{
    class Program
    {
        const int RequestedDayOfMonth = 15;

        static void Main(string[] args)
        {
            // get current date
            var dateTimeNow = DateTime.Today;
            var currentDateYear = dateTimeNow.Year;
            var currentDateMonth = dateTimeNow.Month;

            // calculate date for previous month
            var previousDateYear = currentDateMonth > 1 ? currentDateYear : currentDateYear - 1;
            var previousDateMonth = currentDateMonth > 1 ? currentDateMonth - 1 : 12;

            // calculate date for next month
            var nextDateYear = currentDateMonth < 12 ? currentDateYear : currentDateYear + 1;
            var nextDateMonth = currentDateMonth < 12 ? currentDateMonth + 1 : 1;
            
            // creating DateTime objects for previous and next months
            var previousDateTime = new DateTime(previousDateYear, previousDateMonth, RequestedDayOfMonth);
            var nextDateTime = new DateTime(nextDateYear, nextDateMonth, RequestedDayOfMonth);

            var isoDateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;

            Console.WriteLine(string.Format("15th of the previous month in SQL format is {0}", previousDateTime.ToString(isoDateTimeFormat.SortableDateTimePattern)));
            Console.WriteLine(string.Format("15th of the next month in SQL format is {0}", nextDateTime.ToString(isoDateTimeFormat.SortableDateTimePattern)));
            Console.ReadKey();
        }
    }
}
