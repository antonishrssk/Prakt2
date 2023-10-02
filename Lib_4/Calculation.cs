using System;

namespace Lib_4
{
    public class Calculation
    {
        /// <summary>
        /// Вычисление квадратного корня
        /// </summary>
        /// <param name="value">Число</param>
        /// <returns>Корень из числа, если число больше 0; NaN, если число не больше 0</returns>
        public static double[] Sqrt(int[] mas)
        {
            double[] results = new double[mas.Length];
            for (int i = 0; i < results.Length; i++)
                results[i] = Math.Sqrt(mas[i]);

            return results;
        }
    }
}