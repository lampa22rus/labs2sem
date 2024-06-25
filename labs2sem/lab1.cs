using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab1
    {
        public static void start(int task)
        {
            switch(task)
            {
                case 1:
                     new lab1()._1();
                    break;
                case 2:
                     new lab1()._2();
                    break;
                case 3:
                     new lab1()._3();
                    break;
                default:
                    Console.WriteLine("Задача не найдена");
                    break;
            }
            
        }

        public void _1()
        {
            // Запросите у пользователя значение N
            Console.Write("Введите целое число N (>0): ");
            int N = Convert.ToInt32(Console.ReadLine());
            // Проверка на положительность N
            if (N > 0)
            {
                // Создание массива для хранения нечетных чисел
                int[] oddNumbers = new int[N];
                // Заполнение массива нечетными числами
                for (int i = 0, num = 1; i < N; i++, num += 2)
                {
                    oddNumbers[i] = num;
                }
                // Вывод массива
                Console.WriteLine("Массив первых " + N + " положительных нечетных чисел:");
                foreach (int number in oddNumbers)
                {
                    Console.Write(number + " ");
                }
            }
            else
            {
                Console.WriteLine("Число N должно быть больше 0.");
            }
        }

        public void _2()
        {
            // Предполагаем, что N - это положительное число, введенное пользователем
            Console.Write("Введите положительное число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {
                int[] powersOfTwo = new int[N];
                for (int i = 0; i < N; i++)
                {
                    powersOfTwo[i] = (int)Math.Pow(2, i + 1); // Используем сдвиг влево
                }
                Console.WriteLine("Массив степеней двойки:");
                foreach (int value in powersOfTwo)
                {
                    Console.Write(value + " ");
                }
            }
            else
            {
                Console.WriteLine("Число N должно быть больше 0.");
            }
        }

        public void _3()
        {
            // Предполагаем, что N, A и D - это числа, введенные пользователем
            Console.Write("Введите число N (>1): ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите первый член прогрессии A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите разность прогрессии D: ");
            int D = Convert.ToInt32(Console.ReadLine());
            if (N > 1)
            {
                int[] progression = new int[N];
                for (int i = 0; i < N; i++)
                {
                    progression[i] = A + i * D;
                }
                Console.WriteLine("Массив арифметической прогрессии:");
                foreach (int value in progression)
                {
                    Console.Write(value + " ");
                }
            }
            else
            {
                Console.WriteLine("Число N должно быть больше 1.");
            }
        }
    }
}
