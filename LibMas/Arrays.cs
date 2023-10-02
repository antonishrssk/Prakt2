using Microsoft.Win32;
using System;
using System.IO;

namespace LibMas
{
    public class Arrays
    {
        /// <summary>
        /// Сохранение массива в файл
        /// </summary>
        /// <param name="mas">Массив</param>
        public static void Save(int[] mas)
        {
            // Создаём и настраивем элемент SaveFileDialog
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* |Текстовые файлы (*.txt) | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение массива";

            if (save.ShowDialog() == true) // Открываем диалоговое окно и при успехе работаем с файлом
            {
                StreamWriter file = new StreamWriter(save.FileName); // Создаем поток для работы с файлом и указываем ему имя файла
                file.WriteLine(mas.Length); // Записываем размер массива в файл
                for (int i = 0; i < mas.Length; i++) file.WriteLine(mas[i]); // Записываем элементы массива в файл
                file.Close();
            }
        }

        /// <summary>
        /// Чтение массива из файла
        /// </summary>
        /// <param name="mas">Массив</param>
        /// <param name="isLoaded">Загружен ли массив</param>
        public static void Load(out int[] mas, out bool isLoaded)
        {
            // Создаём и настраиваем элемент OpenFileDialog
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* |Текстовые файлы (*.txt) | *.txt";
            open.FilterIndex = 2;
            open.Title = "Открытие массива";

            if (open.ShowDialog() == true) // Открываем диалоговое окно и при успехе работаем с файлом
            {
                StreamReader file = new StreamReader(open.FileName); // Создаем поток для работы с файлом и указываем ему имя файла
                mas = new int[Convert.ToInt32(file.ReadLine())]; // Создаём массив
                for (int i = 0; i < mas.Length; i++) mas[i] = Convert.ToInt32(file.ReadLine()); // Считываем массив из файла
                file.Close();

                isLoaded = true;
            }
            else
            {
                mas = Array.Empty<int>();
                isLoaded = false;
            }
        }

        /// <summary>
        /// Заполнение массива случайными числами
        /// </summary>
        /// <param name="n">Количество чисел</param>
        /// <returns>Заполненный массив</returns>
        public static int[] Fill(int n)
        {
            int[] result = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++) result[i] = rnd.Next(-100, 101);

            return result;
        }
    }
}