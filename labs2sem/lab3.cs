using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab3
    {
        public static void start(int task)
        {
            switch (task)
            {
                case 1:
                    new lab3()._1();
                    break;
                case 2:
                    new lab3()._2();
                    break;
                case 3:
                    new lab3()._3();
                    break;
                default:
                    Console.WriteLine("Задача не найдена");
                    break;
            }

        }

        public void _1()
        {
            // Создаем массив A и инициализируем его значениями
            int[] A = { 1, 4, 5, 8, 3, 2, 7 };

            // Создаем массив B того же размера, что и массив A
            int[] B = new int[A.Length];

            // Заполняем массив B по заданным условиям
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = (A[i] < 5) ? 2 * A[i] : B[i] = A[i] / 2;
            }

            // Выводим элементы массива B
            Console.Write("Массив B: ");
            foreach (int item in B)
            {
                Console.Write(item + " ");  // Добавляем пробел между элементами
            }
        }

        public void _2()
        {
            // Инициализация массивов A и B
            int[] A = { 1, 6, 3, 9, 5 };
            int[] B = { 2, 4, 7, 8, 5 };
            int N = A.Length;  // Размер массивов A и B

            // Создание массива C того же размера
            int[] C = new int[N];

            // Заполнение массива C максимальными значениями без использования методов
            for (int i = 0; i < N; i++)
            {
                C[i] = (A[i] > B[i]) ? A[i] : B[i];
            }

            // Вывод элементов массива C
            Console.Write("Массив C: ");
            foreach (int item in C)
            {
                Console.Write(item + " ");  // Вывод в одну строку
            }
        }

        public void _3()
        {
            // Инициализация массива A
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int N = A.Length;  // Размер массива A

            // Подсчет количества четных чисел в массиве A
            int countEven = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    countEven++;
                }
            }

            // Создание массива B с размером, равным количеству четных чисел
            int[] B = new int[countEven];

            // Заполнение массива B четными числами
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B[index] = A[i];
                    index++;
                }
            }

            // Вывод размера массива B и его содержимого
            Console.WriteLine("Размер массива B: " + B.Length);
            Console.Write("Содержимое массива B: ");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
        }
    }
}
