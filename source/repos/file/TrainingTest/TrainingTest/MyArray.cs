using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule
{
    public class MyArray
    {
        private int[] ar;
        public MyArray(int[] ar)
        {
            this.ar = ar;
        }

        public int FindMax()
        {
            // тестирование на исключение
            if (ar == null)
                throw new NullReferenceException("Массив не задан");

            //int max = 0; для проверки с ошибкой
            int max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                }
            }
            return max;
        }

        public static double GetAverage(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return (double)sum / ar.Length;
        }
    }
}
