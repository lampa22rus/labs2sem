using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab4
    {
        public static void start(int task)
        {
            switch (task)
            {
                case 1:
                    new lab4()._1();
                    break;
                case 2:
                    new lab4()._2();
                    break;
                case 3:
                    new lab4()._3();
                    break;

                default:
                    Console.WriteLine("Задача не найдена");
                    break;
            }

        }

        public void _1()
        {
            // Пример целочисленного массива
            int[] array = { 3, 5, 6, 8, 11, 14 };

            // Нахождение первого четного числа в массиве
            int? firstEvenNumber = null;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    firstEvenNumber = num;
                    break;
                }
            }

            // Если четное число найдено, увеличиваем все четные числа на его значение
            if (firstEvenNumber.HasValue)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        array[i] += firstEvenNumber.Value;
                    }
                }
            }

            // Вывод результата
            Console.WriteLine("Измененный массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        public void _2()
        {
            // Пример целочисленного массива
            int[] array = { 3, 5, 6, 8, 11, 14 };

            // Нахождение последнего нечетного числа в массиве
            int? lastOddNumber = null;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    lastOddNumber = array[i];
                    break;
                }
            }

            // Если нечетное число найдено, увеличиваем все нечетные числа на его значение
            if (lastOddNumber.HasValue)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        array[i] += lastOddNumber.Value;
                    }
                }
            }

            // Вывод результата
            Console.WriteLine("Измененный массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        public void _3()
        {
            // Пример целочисленного массива
            int[] array = { 3, 5, 6, 8, 11, 14 };

            // Нахождение индексов минимального и максимального элементов
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Поменять местами минимальный и максимальный элементы
            int temp = array[minIndex];
            array[minIndex] = array[maxIndex];
            array[maxIndex] = temp;

            // Вывод результата
            Console.WriteLine("Измененный массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
