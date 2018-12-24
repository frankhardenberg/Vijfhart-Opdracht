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

namespace Vijfhart_Opdracht
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Eerstetxt.Focus();
        }

        double CalculationResult;
                
        private void Bereken_Click(object sender, RoutedEventArgs e)
        {
            if (Optellen.IsChecked == true)
            {
                CalculationResult = Convert.ToDouble(Eerstetxt.Text) + Convert.ToDouble(TweedeTxt.Text);
                Resultaat.Content = Eerstetxt.Text + " + " + TweedeTxt.Text + " = " + CalculationResult;
            }

            if (Aftrekken.IsChecked == true)
            {
                CalculationResult = Convert.ToDouble(Eerstetxt.Text) - Convert.ToDouble(TweedeTxt.Text);
                Resultaat.Content = Eerstetxt.Text + " - " + TweedeTxt.Text + " = " + CalculationResult;
            }

            if (Vermenigvuldigen.IsChecked == true)
            {
                CalculationResult = Convert.ToDouble(Eerstetxt.Text) * Convert.ToDouble(TweedeTxt.Text);
                Resultaat.Content = Eerstetxt.Text + " * " + TweedeTxt.Text + " = " + CalculationResult;
            }

            if (Delen.IsChecked == true)
            {
                if (TweedeTxt.Text != 0.ToString())
                {
                    CalculationResult = Convert.ToDouble(Eerstetxt.Text) / Convert.ToDouble(TweedeTxt.Text);
                    Resultaat.Content = Eerstetxt.Text + " / " + TweedeTxt.Text + " = " + CalculationResult;
                }

                else
                {
                    MessageBox.Show("Kan niet delen door nul!");
                }

            }

            ResultaatGeschiedenis.Items.Add(Resultaat.Content);
        }

        private void Wissen_Click(object sender, RoutedEventArgs e)
        {
            ResultaatGeschiedenis.Items.Clear();
            Eerstetxt.Text = "";
            TweedeTxt.Text = "";
            Resultaat.Content = null;
        }
    }
}
