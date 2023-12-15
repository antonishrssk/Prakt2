using Lib_4;
using LibMas;
using System;
using System.Windows;

namespace Prakt2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miSave_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = new int[lbNumbers.Items.Count];
            for (int i = 0; i < numbers.Length; i++) numbers[i] = Convert.ToInt32(lbNumbers.Items[i]);
            Arrays.Save(numbers);
        }

        private void miOpen_Click(object sender, RoutedEventArgs e)
        {
            Arrays.Load(out int[] numbers, out bool isLoaded);

            if (isLoaded)
            {
                lbNumbers.Items.Clear();
                for (int i = 0; i < numbers.Length; i++) lbNumbers.Items.Add(numbers[i]);
            }
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(tbNumbersCount.Text);
                if (n > 0)
                {
                    lbNumbers.Items.Clear();

                    int[] numbers = Arrays.Fill(n);
                    for (int i = 0; i < numbers.Length; i++) lbNumbers.Items.Add(numbers[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lbSqrt.Items.Clear();

            int[] mas = new int[lbNumbers.Items.Count];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = Convert.ToInt32(lbNumbers.Items[i]);

            double[] results = Calculation.Sqrt(mas);
            for (int i = 0; i < results.Length; i++)
                lbSqrt.Items.Add(results[i]);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lbNumbers.Items.Clear();
            lbSqrt.Items.Clear();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Антонишин Кирилл Сергеевич\n" +
                "Практическая работа №2\n" +
                "Ввести n целых чисел. Вычислить для чисел > 0 функцию √x. Результат обработки каждого числа вывести на экран.",
                "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
