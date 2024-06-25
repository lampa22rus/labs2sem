using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab5
    {
        public static void start(int task)
        {
            switch (task)
            {
                case 1:
                    new lab5()._1();
                    break;
                case 2:
                    new lab5()._2();
                    break;
                case 3:
                    new lab5()._3();
                    break;
                default:
                    Console.WriteLine("Задача не найдена");
                    break;
            }

        }

        public void _1()
        {
            // Пример целочисленного массива и значения K и L
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int K = 3; // номер K
            int L = 5; // номер L

            // Убедимся, что K и L в допустимых пределах
            if (K < 1 || L > array.Length || K > L)
            {
                Console.WriteLine("Неправильные значения K и L");
                return;
            }

            // Преобразование номеров K и L в индексы
            int startIndex = K - 1;
            int endIndex = L - 1;

            // Создание нового массива без элементов от K до L включительно
            int newSize = array.Length - (endIndex - startIndex + 1);
            int[] newArray = new int[newSize];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < startIndex || i > endIndex)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }

            // Вывод размера полученного массива и его содержимого
            Console.WriteLine("Размер нового массива: " + newSize);
            Console.WriteLine("Содержимое нового массива:");
            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }
        }
        public void _2()
        {
            // Пример целочисленного массива
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Подсчет количества четных чисел
            int evenCount = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

            // Создание нового массива для четных чисел
            int[] evenArray = new int[evenCount];
            int index = 0;

            // Копирование четных чисел в новый массив
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenArray[index] = num;
                    index++;
                }
            }

            // Вывод размера полученного массива и его содержимого
            Console.WriteLine("Размер нового массива: " + evenCount);
            Console.WriteLine("Содержимое нового массива:");
            foreach (int num in evenArray)
            {
                Console.Write(num + " ");
            }
        }

        public void _3()
        {
            // Пример целочисленного массива
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Размер нового массива (половина размера исходного массива)
            int newSize = (array.Length + 1) / 2;
            int[] newArray = new int[newSize];

            // Заполнение нового массива элементами с нечетными индексами
            int index = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                newArray[index] = array[i];
                index++;
            }

            // Вывод размера полученного массива и его содержимого
            Console.WriteLine("Размер нового массива: " + newSize);
            Console.WriteLine("Содержимое нового массива:");
            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
