using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GameLibrary;

namespace Game_Test1.Games
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {

        public Person moneys = new();
        public Person fattigues = new();
        public Person satietys = new();
        public Game()
        {
            InitializeComponent();
        }

        private void BtBack(object sender, RoutedEventArgs e) // Выход
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            this.Close();
        }

        private void BtClickWorck(object sender, RoutedEventArgs e) // Статы
        {
            double fattigue = Convert.ToDouble(TextBoxFatigue.Text);
            double satietty = Convert.ToDouble(TextBoxSatiety.Text);

            if(fattigue > 0 && satietty > 0)
            {
                double x = Convert.ToDouble(TextCollX.Text);
                double mymoney = Convert.ToDouble(TextMoney.Text);
                moneys.SetMoneys(mymoney, x);
                TextMoney.Text = Convert.ToString(moneys.Money);


                satietys.BecrFatigue(satietty);
                TextBoxSatiety.Text = Convert.ToString(satietys.Fatigue);


                fattigues.ВecrSatietys(fattigue);
                TextBoxFatigue.Text = Convert.ToString(fattigues.Satiety);
            }
            else
            {
                MessageBox.Show("Вы проиграли", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                MainWindow mainWindow = new();
                mainWindow.Show();
                this.Close();
            }

            
        }

        private void BtWer(object sender, RoutedEventArgs e) // Энергетик
        {
            double mymoney = Convert.ToInt32(TextMoney.Text);
            double ener = Convert.ToInt32(TextToDay.Text);
            if (mymoney > 9 && ener > 0)
            {
                double z = Convert.ToDouble(TextBuyEnergy.Text);
                moneys.BecrMoney(mymoney, z);
                TextMoney.Text = Convert.ToString(moneys.Money);

                double wer = Convert.ToDouble(TextBoxFatigue.Text);
                satietys.SetWer(wer);
                TextBoxFatigue.Text = Convert.ToString(satietys.Satiety);

                double energy = ener - 1;
                TextToDay.Text = Convert.ToString(energy);
            }
            else
            {
                Warr();
            }
        }
        private void BtPie(object sender, RoutedEventArgs e) // Сытость
        {
            double mymoney = Convert.ToInt32(TextMoney.Text);
            if (mymoney > 19)
            {
                double z = Convert.ToDouble(TextBuyPie.Text);
                moneys.BecrMoney(mymoney, z);
                TextMoney.Text = Convert.ToString(moneys.Money);

                double pie = Convert.ToDouble(TextBoxSatiety.Text);
                satietys.SetPie(pie);
                TextBoxSatiety.Text = Convert.ToString(satietys.Fatigue);
            }
            else
            {
                Warr();
            }
        }

        private void BtPlusWorck(object sender, RoutedEventArgs e) // Прибавка денег за клик
        {
            double y = Convert.ToDouble(TextCollY.Text); // Кол-во прибавки к деньгам
            double x = Convert.ToDouble(TextCollX.Text); // Деньги за клик
            double z = Convert.ToDouble(TextCollYm.Text); // Стоимость прибавки
            double mymoney = Convert.ToInt32(TextMoney.Text); // Деньги у персонажа
            if (mymoney > 49)
            {
                double sum = y + x;
                moneys.BecrMoney(mymoney, z);
                TextCollX.Text = Convert.ToString(sum);
                TextMoney.Text = Convert.ToString(moneys.Money);
            }
            else
            {
                Warr();
            }

            
        }
        private void BtToday_Click(object sender, RoutedEventArgs e)
        {
            double mymoney = Convert.ToInt32(TextMoney.Text); // Деньги
            moneys.ToDayDay(mymoney);
            TextMoney.Text = Convert.ToString(moneys.Money);

            double ener = Convert.ToInt32(TextToDay.Text); // Энергетики
            double energy = ener + 1;
            TextToDay.Text = Convert.ToString(energy);

            double day = Convert.ToDouble(TextDay.Text); // Дни
            double days = day + 1;
            TextDay.Text = Convert.ToString(days);

            double pie = Convert.ToDouble(TextBoxSatiety.Text); // Сытость
            double pies = pie - 10;
            TextBoxSatiety.Text = Convert.ToString(pies);

            double energyins = 100;
            TextBoxFatigue.Text = Convert.ToString(energyins);


        }



        public void Warr()
        {
            MessageBox.Show("Ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

       
    }
}
