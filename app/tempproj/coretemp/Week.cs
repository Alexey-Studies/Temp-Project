using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
namespace app
{
    class Week
    {

        public bool typeweek { get; set; }
        public void DayLessons(int day, int Group)
        {
            switch (Group)
            {
                case 1:
                    switch (day)
                    {
                        case 1:
                            List<string> Monday_KI = new List<string>();
                            Monday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Monday_KI.Add("-");
                            Monday_KI.Add("Численные методы и операции исчисления");
                            Monday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Monday_KI.Add("-");
                            foreach (var ex in Monday_KI) { Console.WriteLine(ex); }
                            break;
                        case 2:
                            List<string> Tuesday_KI = new List<string>();
                            Tuesday_KI.Add("-");
                            Tuesday_KI.Add("-");
                            Tuesday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Tuesday_KI.Add("Численные методы и операции исчисления");
                            Tuesday_KI.Add("-");
                            foreach (var ex in Tuesday_KI) { Console.WriteLine(ex); }
                            break;
                        case 3:
                            List<string> Wednesday_KI = new List<string>();
                            Wednesday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Wednesday_KI.Add("-");
                            Wednesday_KI.Add("Численные методы и операции исчисления");
                            Wednesday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Wednesday_KI.Add("-");
                            foreach (var ex in Wednesday_KI) { Console.WriteLine(ex); }
                            break;
                        case 4:
                            List<string> Thursday_KI = new List<string>();
                            Thursday_KI.Add("-");
                            Thursday_KI.Add("-");
                            Thursday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Thursday_KI.Add("Численные методы и операции исчисления");
                            Thursday_KI.Add("-");
                            foreach (var ex in Thursday_KI) { Console.WriteLine(ex); }
                            break;
                        case 5:
                            List<string> Friday_KI = new List<string>();
                            Friday_KI.Add("-");
                            Friday_KI.Add("-");
                            Friday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Friday_KI.Add("Численные методы и операции исчисления");
                            Friday_KI.Add("-");
                            foreach (var ex in Friday_KI) { Console.WriteLine(ex); }
                            break;
                    }
                break;
                case 2:
                    switch (day)
                    {
                        case 1:
                            List<string> Monday_PI = new List<string>();
                            Monday_PI.Add("Численные методы и операции исчисления");
                            Monday_PI.Add("Численные методы и операции исчисления");
                            Monday_PI.Add("Численные методы и операции исчисления");
                            Monday_PI.Add("Численные методы и операции исчисления");
                            Monday_PI.Add("Численные методы и операции исчисления");
                            foreach (var ex in Monday_PI) { Console.WriteLine(ex); }
                            break;
                        case 2:
                            List<string> Tuesday_PI = new List<string>();
                            Tuesday_PI.Add("Численные методы и операции исчисления");
                            Tuesday_PI.Add("Численные методы и операции исчисления");
                            Tuesday_PI.Add("Численные методы и операции исчисления");
                            Tuesday_PI.Add("Численные методы и операции исчисления");
                            Tuesday_PI.Add("Численные методы и операции исчисления");
                            foreach (var ex in Tuesday_PI) { Console.WriteLine(ex); }
                            break;
                        case 3:
                            List<string> Wednesday_PI = new List<string>();
                            Wednesday_PI.Add("Численные методы и операции исчисления");
                            Wednesday_PI.Add("Численные методы и операции исчисления");
                            Wednesday_PI.Add("Численные методы и операции исчисления");
                            Wednesday_PI.Add("Численные методы и операции исчисления");
                            Wednesday_PI.Add("Численные методы и операции исчисления");
                            foreach (var ex in Wednesday_PI) { Console.WriteLine(ex); }
                            break;
                        case 4:
                            List<string> Thursday_PI = new List<string>();
                            Thursday_PI.Add("Численные методы и операции исчисления");
                            Thursday_PI.Add("Численные методы и операции исчисления");
                            Thursday_PI.Add("Численные методы и операции исчисления");
                            Thursday_PI.Add("Численные методы и операции исчисления");
                            Thursday_PI.Add("Численные методы и операции исчисления");
                            foreach (var ex in Thursday_PI) { Console.WriteLine(ex); }
                            break;
                        case 5:
                            List<string> Friday_PI = new List<string>();
                            Friday_PI.Add("Численные методыауцазщцлщазцусления");
                            Friday_PI.Add("Численные методы и операции исчисления");
                            Friday_PI.Add("Численные методы и операции исчисления");
                            Friday_PI.Add("Численные методы и операции исчисления");
                            Friday_PI.Add("Численные методы и операции исчисления");
                            foreach (var ex in Friday_PI) { Console.WriteLine(ex); }
                            break;
                    }
               break;
                    default: Console.WriteLine("если кто-то видет это сообщение то знайте я забыл добавить группы и их расписание"); break;

            }
        }
    }
}
