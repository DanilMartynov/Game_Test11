using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Person
    { 

        public double Money { get; private set; } // Деньги
        public double Satiety { get; set; } // Усталость
        public double Fatigue { get; set; } // Сытость
        public double Experience { get; set; } // Опыт


        public void SetMoneys(double money, double x)
        {
            
            Money = money + x;
        }

        public void ВecrSatietys(double satietty) // Вычисление Усталости
        {
            Satiety = satietty - 1.5;
        }

        public void BecrFatigue(double fatigue) // Вычисление Сытости
        {
            Fatigue = fatigue -1;
        }

        public void SetWer(double wer) // Прибавление усталости
        {  
            Satiety = wer + 20;  
        }

        public void SetPie(double pie)
        {
            Fatigue = pie + 30;
        }

        public void BecrMoney(double mymoney, double z)
        {
            Money = mymoney - z;
        }

        public void ToDayDay(double mymoney)
        {
            Money = mymoney + 20;
        }

        public override string ToString()
        {
            return Money.ToString();
        }
    }
}
