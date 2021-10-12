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

        private decimal getKb()
        {
            try
            {
                decimal result = decimal.Parse(TextBoxBytes.Text) / 1024;
                return Math.Round(result, 2);
            }
            catch
            {
                MessageBox.Show("Не правильно введено число!");
                return -1;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            Thread.Sleep(TimeSpan.FromSeconds(1));
            decimal result = getKb();
            if (result != -1)
            {
                GridResult.Visibility = Visibility.Visible;
                LabelResult.Content = $"{TextBoxBytes.Text} байт = {result} Кб";
            }
            this.Cursor = null;
        }
    }
}
