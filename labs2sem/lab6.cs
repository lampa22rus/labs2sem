using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab6
    {
        public static void start(int task)
        {
            switch (task)
            {
                case 1:
                    new lab6()._1();
                    break;
                default:
                    Console.WriteLine("Задача не найдена");
                    break;
            }

        }

        public void _1()
        {
            // Пример целочисленного массива
            int[] array = { 5, 3, 8, 4, 2, 6 };

            // Размер массива
            int n = array.Length;

            // Пузырьковая сортировка с выводом содержимого массива после каждого просмотра
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Обмен элементов
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }

                // Вывод содержимого массива после каждого просмотра
                Console.WriteLine($"После {i + 1} просмотра:");
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
