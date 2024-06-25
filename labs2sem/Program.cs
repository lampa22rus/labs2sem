using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    
    internal class Program
    {
        const int lab = 8;
        const int task = 1;
        static void Main(string[] args)
        {
            Console.WriteLine($"Грищенко А.Д 5.306-2\n");
            switch (lab)
            {
                case 1:
                    lab1.start(task);
                    break;
                case 2:
                    lab2.start(task);
                    break;
                case 3:
                    lab3.start(task);
                    break;
                case 4:
                    lab4.start(task);
                    break;
                case 5:  
                    lab5.start(task);
                    break;
                case 6:  
                    lab6.start(task);
                    break;
                case 7:  
                    lab7.start(task);
                    break;
                case 8:  
                    lab8.start(task);
                    break;
                case 9:  
                    lab9.start(task);
                    break;
                default:
                    Console.WriteLine("Лабороторная работа не найдена");
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Нажмите enter для продолжения");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
