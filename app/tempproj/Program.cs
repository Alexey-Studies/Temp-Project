using System;
using System.IO;
using System.Collections.Generic;
namespace app
{
    class MainClass
    {
        //int dayofweek => (int)date.DayOfWeek;//в виде лямбды

        enum Groups 
        {
            KI=1,
            PI = 2,
            SP = 3, 
            KSC = 4
        }
        public static void Main()
        {
            // string nameOF = "Математика";
            //Day day = new Day();
            // day.GethoursLessons(nameOF);
            
            DateTime date;                      //получение сегоднешнего дня
            
            date = DateTime.Now;
            int dayofweek = (int)date.DayOfWeek;
            Console.WriteLine(dayofweek);


            Week week = new Week();
            //week.DayOfWeak(dayofweek);

            //Console.WriteLine("Введите желаемый день недели");
            //string response = Console.ReadLine();
            //int temp =Convert.ToInt32(response);
            week.DayLessons(5, (int)Groups.KI);
        }
    }
}