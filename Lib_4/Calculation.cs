using System;

namespace Lib_4
{
    public class Calculation
    {
        /// <summary>
        /// ���������� ����������� �����
        /// </summary>
        /// <param name="value">�����</param>
        /// <returns>������ �� �����, ���� ����� ������ 0; NaN, ���� ����� �� ������ 0</returns>
        public static double[] Sqrt(int[] mas)
        {
            double[] results = new double[mas.Length];
            for (int i = 0; i < results.Length; i++)
                results[i] = Math.Sqrt(mas[i]);

            return results;
        }
    }
}