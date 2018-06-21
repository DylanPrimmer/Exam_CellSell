//Dylan Primmer
//Exam
//Cellsell
//June 21, 2018
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DylanPrimmerBananas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {// creates variables
        int DaytimeA = new int();
        int EveningA = new int();
        int WkndA = new int();
        int DaytimeB = new int();
        int EveningB = new int();
        int WkndB = new int();
        double DaytimeAValue = 0;
        double EveningAValue = 0.15;
        double WkndAValue = 0.20;
        double PlanACost;
        int DayMinsa = 1;
        double DaytimeBValue = 0;
        double EveningBValue = 0.35;
        double WkndBValue = 0.25;
        double PlanBCost;
        int DayMinsb = 1;
       

        
        public MainWindow()
        {
            InitializeComponent();
           
            
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        { //set values for Plan A
            int.TryParse(DayMins.Text, out DaytimeA);
            int.TryParse(EveMins.Text, out EveningA);
            int.TryParse(WkndMins.Text, out WkndA);
            int.TryParse(DayMins.Text, out DayMinsa);
            if (DayMinsa <= 100)
            {
                DaytimeAValue = 0;
            }
            else
            {

                DaytimeAValue = 0.25;
                DaytimeA = DaytimeA - 100;
            }
            PlanACost = DaytimeA * DaytimeAValue;

            PlanACost = PlanACost + (EveningA * EveningAValue);
            PlanACost = PlanACost + (WkndA * WkndAValue);
            AOutput.Text = "$" + PlanACost.ToString();
            //set values for Plan B
            int.TryParse(DayMins.Text, out DaytimeB);
            int.TryParse(EveMins.Text, out EveningB);
            int.TryParse(WkndMins.Text, out WkndB);
            int.TryParse(DayMins.Text, out DayMinsb);
            if (DayMinsb <= 250)
            {
                DaytimeBValue = 0;
            }
            else
            {
                DaytimeBValue = 0.45;
                DaytimeB = DaytimeB - 250;
            }

            PlanBCost = DaytimeB * DaytimeBValue; 
            PlanBCost = PlanBCost + (EveningB * EveningBValue);
            PlanBCost = PlanBCost + (WkndB * WkndBValue);
            BOutput.Text = "$" + PlanBCost.ToString();
        }
    }
}
