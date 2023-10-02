using Microsoft.Win32;
using System;
using System.IO;

namespace LibMas
{
    public class Arrays
    {
        /// <summary>
        /// ���������� ������� � ����
        /// </summary>
        /// <param name="mas">������</param>
        public static void Save(int[] mas)
        {
            // ������ � ���������� ������� SaveFileDialog
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "��� ����� (*.*) | *.* |��������� ����� (*.txt) | *.txt";
            save.FilterIndex = 2;
            save.Title = "���������� �������";

            if (save.ShowDialog() == true) // ��������� ���������� ���� � ��� ������ �������� � ������
            {
                StreamWriter file = new StreamWriter(save.FileName); // ������� ����� ��� ������ � ������ � ��������� ��� ��� �����
                file.WriteLine(mas.Length); // ���������� ������ ������� � ����
                for (int i = 0; i < mas.Length; i++) file.WriteLine(mas[i]); // ���������� �������� ������� � ����
                file.Close();
            }
        }

        /// <summary>
        /// ������ ������� �� �����
        /// </summary>
        /// <param name="mas">������</param>
        /// <param name="isLoaded">�������� �� ������</param>
        public static void Load(out int[] mas, out bool isLoaded)
        {
            // ������ � ����������� ������� OpenFileDialog
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "��� ����� (*.*) | *.* |��������� ����� (*.txt) | *.txt";
            open.FilterIndex = 2;
            open.Title = "�������� �������";

            if (open.ShowDialog() == true) // ��������� ���������� ���� � ��� ������ �������� � ������
            {
                StreamReader file = new StreamReader(open.FileName); // ������� ����� ��� ������ � ������ � ��������� ��� ��� �����
                mas = new int[Convert.ToInt32(file.ReadLine())]; // ������ ������
                for (int i = 0; i < mas.Length; i++) mas[i] = Convert.ToInt32(file.ReadLine()); // ��������� ������ �� �����
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
        /// ���������� ������� ���������� �������
        /// </summary>
        /// <param name="n">���������� �����</param>
        /// <returns>����������� ������</returns>
        public static int[] Fill(int n)
        {
            int[] result = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++) result[i] = rnd.Next(-100, 101);

            return result;
        }
    }
}