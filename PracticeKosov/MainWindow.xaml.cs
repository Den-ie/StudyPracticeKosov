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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskLibrary;

namespace PracticeKosov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        private void Task1Calc(object sender, RoutedEventArgs e)
        {
            int[] array = new int[5];
            int x = Tasks.ArrayFirstNotEven(array);
        }

        private void AboutTask1(object sender, RoutedEventArgs e)
        {
            int[,] matrix = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = (rnd.Next(0, 10));
                }
            }

            int[] array = Tasks.MatrixSummOfColumns(matrix);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FirstTaskClick(object sender, RoutedEventArgs e)
        {
            int j = 0;
            bool f = int.TryParse(TwoDigit.Text, out int x);

            if (!f)
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int Count = Int32.Parse(TwoDigit.Text);

            while (Count > 0)
            {
                j++;
                Count /= 10;
            }


            if (j != 2)
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (Tasks.DoubleDigitNotEven(x))
                {
                    MessageBox.Show("Состоит только из нечетных цифр");
                }
                else
                    MessageBox.Show("Не состоит только из нечетных цифр");
            }
        }

        private void SecondTaskClick(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(FirstDigit.Text, out int x1) || !int.TryParse(SecondDigit.Text, out int x2) || !int.TryParse(ThirdDigit.Text, out int x3))
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                int summ = Tasks.TripleDigitSumm(x1, x2, x3);
                MessageBox.Show("Сумма наименьших равна " + summ);
            }
        }

        int[] array;

        private void CreateArray(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(ArraySize.Text, out int x))
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                array = new int[x];
                Random rnd = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(0, 11);
                }

                Table3Tasks.ItemsSource = VisualArray.ToDataTable(array).DefaultView;

                int y = Tasks.ArrayFirstNotEven(array);

                if(y < 0)
                {
                    MessageBox.Show("Нечетных чисел нет");
                }
                else
                {
                    Answer3.Text = Convert.ToString(y);
                }
            }
        }

        int[,] matrix;

        private void CreateMatrix(object sender, RoutedEventArgs e)
        {
            matrix = new int[3, 8];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }

            MatrixTabele4.ItemsSource = VisualArray.ToDataTable(matrix).DefaultView;

            int[] mas = Tasks.MatrixSummOfColumns(matrix);

            ArrayTabele4.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }
    }
}
