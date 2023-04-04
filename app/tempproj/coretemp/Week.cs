using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace app
{
    class Week
    {

        public string typeweek { get; set; }
        
        public void UpDownTypeWeek() 
        {
           

            DateTime myDateTime = DateTime.Now;
            int dayofweek = (int)myDateTime.DayOfWeek;
            
            double firstDayOfYear = (double)new DateTime(myDateTime.Year, 1, 1).DayOfWeek;
            double weekNumber = (myDateTime.DayOfYear + firstDayOfYear) / 7;


            Console.WriteLine(Math.Ceiling(weekNumber));


            if ((Math.Ceiling(weekNumber+0.3) % 2 == 0)) { typeweek = "сейчас верхняя неделя"; } else { typeweek = "сейчас нижняя неделя"; }
            Console.WriteLine(typeweek);
        }
    }
}
