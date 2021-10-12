using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Praktikum1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int firstNumber = 0;
        int secondNumber = 0;
        int thirdNumber = 0;
        private int getNumber()
        {
            string[] stringNumbers = TextBoxNumbers.Text.Split(' ');
            try
            {
                firstNumber = int.Parse(stringNumbers[0]);
                secondNumber = int.Parse(stringNumbers[1]);
                thirdNumber = int.Parse(stringNumbers[2]);
            }
            catch
            {
                MessageBox.Show("Введены не все числа");
                return 0;
            }
            return 1;
        }

        private int getSum()
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        private int getMulti()
        {
            return firstNumber * secondNumber * thirdNumber;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Thread.Sleep(TimeSpan.FromSeconds(1));
            if (getNumber() == 1)
            {
                GridResult.Visibility = Visibility.Visible;
                LabelResult.Content = $"сумма: {getSum()}";
                await Task.Delay(2000);
                LabelResult.Content = $"произведение: {getMulti()}";
            }
            this.Cursor = null;
        }
    }
}
