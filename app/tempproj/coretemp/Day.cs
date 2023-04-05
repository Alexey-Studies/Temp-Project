using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO; //для сохранения данных в txt
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

/* backend Дулин Никита
 backend Витвицкий Данил
UI/UX Вавилов Данил
CodeReview Ким Крмаджян
QA Владимир Балабанов*/
namespace app
{
    
    class Day 
    {
        
        
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
        public string GethoursLessons(string NameDiscipline)  
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
                /*Console.WriteLine("Line number: {0}", counter);*/ //показывает на какой строчке премет
                file.Close();
            }
            catch (Exception e) {Console.WriteLine("ошибка чтения: " + e.Message);}
            finally {Console.WriteLine("чтение выполнено успешно");}

            string secondLine = File.ReadLines("HoursOfWork.txt").ElementAtOrDefault(counter);
            Console.WriteLine(secondLine);
            
            string[] readText = File.ReadAllLines("HoursOfWork.txt");
            using (StreamWriter secfile = new StreamWriter("HoursOfWork.txt", true)) //если поставить false то файлик будет стираться
            {
                
                if (counter == readText.Length)
                {
                    Console.WriteLine("Такой предмет не найден");
                }
                secfile.Close();
            }
             return  secondLine;
            
        }
        public void SetHoursLessons(string NameDiscipline) 
        {
            
            string str = GethoursLessons(NameDiscipline); 
            int value;
            int.TryParse(string.Join("", str.Where(c => char.IsDigit(c))), out value);
            value=value - 2;
            string valuestr=Convert.ToString(value);
            string newstr = NameDiscipline +" "+ valuestr;

            ReplaceInFile("HoursOfWork.txt", str, newstr);


        }
        private void ReplaceInFile(string filePath, string searchText, string replaceText)
         {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
            
         }

    }
}
