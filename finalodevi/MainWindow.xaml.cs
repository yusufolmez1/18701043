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

namespace finalodevi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1;
        double num2;
        double totalNumber;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void clearr()
        {
            numberA.Clear();
            numberB.Clear();
        }
        private void AddingNumbers(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(numberA.Text); 
            num2 = Convert.ToDouble(numberB.Text); 

            totalNumber = num1 + num2;

            result.Content = totalNumber.ToString(); 
            clearr();
        }

        private void SubtractNumbers(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(numberA.Text); 
            num2 = Convert.ToDouble(numberB.Text); 

            totalNumber = num1 - num2; 

            result.Content = totalNumber.ToString(); 
            clearr();
        }

        private void MultiplyNumbers(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(numberA.Text); 
            num2 = Convert.ToDouble(numberB.Text);

            totalNumber = num1 * num2;

            result.Content = totalNumber.ToString(); 
            clearr();
        }

        private void DivideNumbers(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToDouble(numberA.Text);
            num2 = Convert.ToDouble(numberB.Text); 

            totalNumber = num1 / num2; 

            totalNumber = Math.Round(totalNumber, 2); 

            result.Content = totalNumber.ToString(); 
            clearr();
        }
       
    }
}
