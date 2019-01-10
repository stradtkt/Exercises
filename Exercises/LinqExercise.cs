using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercises
{
    class LinqExercise
    {

        public void dayOfWeek()
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            var daysLinq = from WeekDay in days select WeekDay;
            foreach(var WeekDay in daysLinq)
            {
                Console.WriteLine(WeekDay);
            }
            Console.WriteLine();
        }

    }
}
