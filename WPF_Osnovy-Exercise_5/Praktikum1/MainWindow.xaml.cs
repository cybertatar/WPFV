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
    public class AnswerGenerator
    {
        static public string GetRandomAnswer()
        {
            string[] variableAnswer = new string[] { 
                "Так точно", "Маловероятно", "Возможно", "Очень сомнительно", "Точно нет" 
            };
            Random rnd = new Random();
            int num = rnd.Next(0, variableAnswer.Length);
            return variableAnswer[num];
        }
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия кнопки
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            // Ставим курсор ожидания.
            this.Cursor = Cursors.Wait;
            // Делаем задержку, для создания эффекта того, что программа задумалась.
            Thread.Sleep(TimeSpan.FromSeconds(1));
            // Берем случайный ответ.
            txtAnswer.Text = AnswerGenerator.GetRandomAnswer();
            // Восстанавливаем прежнее состояние курсора.
            this.Cursor = null;
        }
        private void txtQuestion_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

    }
}
