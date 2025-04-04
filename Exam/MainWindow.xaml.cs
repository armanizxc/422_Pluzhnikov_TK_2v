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

namespace Exam
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int module1Score = int.Parse(Module1Score.Text);
                int module2Score = int.Parse(Module2Score.Text);
                int module3Score = int.Parse(Module3Score.Text);

                if (module1Score < 0 || module1Score > 22)
                {
                    MessageBox.Show("Ошибка: Введенные баллы за Модуль 1 должны быть от 0 до 22!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (module2Score < 0 || module2Score > 38)
                {
                    MessageBox.Show("Ошибка: Введенные баллы за Модуль 2 должны быть от 0 до 38!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (module3Score < 0 || module3Score > 20)
                {
                    MessageBox.Show("Ошибка: Введенные баллы за Модуль 3 должны быть от 0 до 20!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                int totalScore = module1Score + module2Score + module3Score;
                TotalScore.Text = totalScore.ToString();

                string grade = GetGrade(totalScore);
                Grade.Text = grade;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Введите корректные числовые значения для всех полей.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public string GetGrade(int totalScore)
        {
            if (totalScore >= 56 && totalScore <= 80)
                return "5 (Отлично)";
            else if (totalScore >= 32 && totalScore <= 55)
                return "4 (Хорошо)";
            else if (totalScore >= 16 && totalScore <= 31)
                return "3 (Удовлетворительно)";
            else
                return "2 (Неудовлетворительно)";
        }
    }
}
