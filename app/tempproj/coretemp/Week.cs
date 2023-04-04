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

        public void KI()
        {
            List<string> Monday = new List<string>();
            Monday.Add("Моделирование цифровых узлов компьютерных систем");
            Monday.Add("-");
            Monday.Add("Численные методы и операции исчисления");
            Monday.Add("Моделирование цифровых узлов компьютерных систем");
            Monday.Add("-");
        }
        public void Predmet()
        {
            Vector<Group> disc = new Vector<Group>();
            Pofig.Add(Monday);
            foreach (var ex in disc)
            {
                Console.Writeline(ex);
            }
        }

    }
}