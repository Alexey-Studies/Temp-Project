using System;
using System.IO;
using System.Collections.Generic;
namespace app
{
    class MainClass
    {


        enum Groups
        {
            KI = 1,
            PI = 2,
            SP = 3,
            KSC = 4
        }
        public static void Main()
        {
            Week week = new Week();
            Semestr semestr = new Semestr();
            Lesson lesson = new Lesson();

            string nameOF = "Математика";        //работа с файлами (проведённые занятие) (не закончено)
            Day day = new Day();
            Console.WriteLine(day.GethoursLessons(nameOF));
            Console.WriteLine();
            day.SetHoursLessons(nameOF);
            Console.WriteLine();


            DateTime date;                      //получение сегоднешнего дня
            date = DateTime.Now;
            int dayofweek = (int)date.DayOfWeek;
            Console.WriteLine($"сегодня {dayofweek} день с начала недели");
            Console.WriteLine();




            lesson.DayLessons(5, (int)Groups.PI); //полученние у какой группы пары на текущий день
            Console.WriteLine();


            semestr.watchData();            //дата начала семестра/дата конца семестра
            Console.WriteLine();
            week.UpDownTypeWeek();     //верхняя нижняя

        }
    }
}