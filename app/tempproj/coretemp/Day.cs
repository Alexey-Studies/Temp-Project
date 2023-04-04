using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO; //для сохранения данных в txt
using System.Reflection.PortableExecutable;

/* backend Дулин Никита
 backend Витвицкий Данил
UI/UX Вавилов Данил
CodeReview Ким Крмаджян
QA Владимир Балабанов*/
namespace app
{

    class Day 
    {
        
        /*это надо распределить по файлам по идее (Витвицкий)*/
        public int hoursofwork { get; set; }// реализвать функцией ( файлы чтения->поиск нужной строки -> поиск цифр ->применение из переменной)
      
        public void GetAllHoursLessons() 
        {
            using (FileStream stream1 = File.OpenRead("HoursOfWork.txt"))
            {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);
                stream1.Close();
            }
        }
        public void GethoursLessons(string NameDiscipline) //добавляем в параметры название предмета  enum/struct ищем и выводм результат 
        {
            int counter = 0;
            try
            {
                string line;
                 StreamReader file = new StreamReader("HoursOfWork.txt");
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(NameDiscipline))
                    {
                        break;
                    }
                    counter++;
                }
                Console.WriteLine("Line number: {0}", counter);
                file.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("ошибка чтения: " + e.Message);
            }
            finally
            {
                Console.WriteLine("чтение выполнено успешно");
            }
            string secondLine = File.ReadLines("HoursOfWork.txt").ElementAtOrDefault(counter);
            Console.WriteLine(secondLine);
        }

     
    }
}
