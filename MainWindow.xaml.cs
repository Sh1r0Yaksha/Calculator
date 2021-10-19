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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Numbers Numbers { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Numbers = new Numbers { Num1 = "0", Num2 = "0" };
            this.DataContext = Numbers;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers.result = double.Parse(Numbers.Num1) + double.Parse(Numbers.Num2);
            Numbers.Result = Numbers.result.ToString();
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers.result = double.Parse(Numbers.Num1) - double.Parse(Numbers.Num2);
            Numbers.Result = Numbers.result.ToString();
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers.result = double.Parse(Numbers.Num1) * double.Parse(Numbers.Num2);
            Numbers.Result = Numbers.result.ToString();
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers.result = double.Parse(Numbers.Num1) / double.Parse(Numbers.Num2);
            Numbers.Result = Numbers.result.ToString();
        }
    }
}
