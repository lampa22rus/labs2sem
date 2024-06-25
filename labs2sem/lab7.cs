using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab7
    {
        public static void start(int task)
        {
            switch (task)
            {
                case 1:
                    new lab7()._1();
                    break;
                case 2:
                    new lab7()._2();
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

        // Сортировка простым выбором
        for (int i = 0; i < n - 1; i++)
        {
            // Нахождение максимального элемента в неотсортированной части массива
            int maxIndex = 0;
            for (int j = 1; j < n - i; j++)
            {
                if (array[j] > array[maxIndex])
                {
                    maxIndex = j;
                }
            }

            // Обмен максимального элемента с последним элементом неотсортированной части массива
            int temp = array[maxIndex];
            array[maxIndex] = array[n - 1 - i];
            array[n - 1 - i] = temp;

            // Вывод содержимого массива после каждого шага
            Console.WriteLine($"После {i + 1} шага:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
        }
        public void _2()
        {
            // Пример целочисленного массива
            int[] array = { 5, 3, 8, 4, 2, 6 };

            // Размер массива
            int n = array.Length;

            // Сортировка простыми вставками
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Перемещение элементов массива, которые больше key, на одну позицию вперед
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;

                // Вывод содержимого массива после обработки каждого элемента
                Console.WriteLine($"После обработки элемента {i + 1}:");
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
