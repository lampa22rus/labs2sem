using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab2
    {
        public static void start(int task)
        {
            switch (task)
            {
                case 1:
                    new lab2()._1();
                    break;
                case 2:
                    new lab2()._2();
                    break;
                case 3:
                    new lab2()._3();
                    break;
                default:
                    Console.WriteLine("Задача не найдена");
                    break;
            }

        }

        public void _1()
        {
            // Инициализация массива A размером 10 с ненулевыми целыми числами
            int[] A = { 11, 5, 3, 4, 5, 6, 2, 8, 9, 10 };

            // Искомый элемент, удовлетворяющий условию A[k] < A[9]
            int result = 0;

            // Перебор элементов массива (кроме последнего)
            for (int i = 0; i < 9; i++)
            {
                if (A[i] < A[9])
                {
                    result = A[i];
                    break; // Выход из цикла, как только найден первый подходящий элемент
                }
            }

            // Вывод результата
            Console.WriteLine(result);
        }
        public void _2()
        {
            int[] A = { 5, 20, 15, 25, 10, 30, 45, 50, 35, 60 };  // Пример массива
            int lastIndex = 0;  // Начальное значение для индекса искомого элемента

            for (int k = 1; k < 9; k++)  // Проверяем элементы с 1 по 8, так как последний элемент не включается в проверку
            {
                if (A[0] < A[k] && A[k] < A[9])  // Условие A1 < Ak < A10
                {
                    lastIndex = k;  // Обновляем lastIndex на текущий индекс, если элемент удовлетворяет условию
                }
            }

            // Если lastIndex остался 0, проверяем, удовлетворяет ли A[0] условию, если нет, то выводим 0
            if (lastIndex == 0 && !(A[0] < A[0] && A[0] < A[9]))
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(lastIndex + 1);  // Выводим индекс последнего подходящего элемента, увеличенный на 1 (для удобства)
            }
        }
        public void _3()
        {
            // Задаем массив и значения K и L
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int K = 3;  // Начальный индекс (должен быть на 1 меньше, так как в C# индексация начинается с 0)
            int L = 7;  // Конечный индекс

            // Проверяем, что K и L удовлетворяют условиям задачи
            if (1 <= K && K <= L && L <= array.Length)
            {
                int sum = 0;
                // Вычисляем сумму элементов от K до L включительно
                for (int i = K - 1; i < L; i++)  // K-1 и L-1 для корректной работы с индексами
                {
                    sum += array[i];
                }

                Console.WriteLine("Сумма элементов с индексами от {0} до {1} включительно равна {2}", K, L, sum);
            }
            else
            {
                Console.WriteLine("Значения K и L вне допустимого диапазона");
            }
        }
    }
}
