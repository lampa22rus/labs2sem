using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab8
    {
        public static void start(int task)
        {
            switch (task)
            {
                case 1:
                    new lab8()._1();
                    break;
                default:
                    Console.WriteLine("Задача не найдена");
                    break;
            }

        }

        public void _1()
        {
            LinkedList list = new LinkedList();
            list.Head = new ListNode(0, new ListNode(1, new ListNode(1)));

            bool success = list.InsertAt(4, 2); // Вставляем значение 4 на 2-ю позицию (индексация с 0)

            if (success)
            {
                Console.WriteLine("Вставка успешна.");
            }
            else
            {
                Console.WriteLine("Вставка не удалась.");
            }
        }
        public class ListNode
        {
            public int Value;
            public ListNode Next;

            public ListNode(int value = 0, ListNode next = null)
            {
                Value = value;
                Next = next;
            }
        }

        public class LinkedList
        {
            public ListNode Head;

            public LinkedList()
            {
                Head = null;
            }

            public bool InsertAt(int value, int k)
            {
                // Создаем новый узел
                ListNode newNode = new ListNode(value);

                // Если нужно вставить в начало списка
                if (k == 0)
                {
                    newNode.Next = Head;
                    Head = newNode;
                    return true;
                }

                // Найдем узел, перед которым нужно вставить новый
                ListNode current = Head;
                for (int i = 0; i < k - 1; i++)
                {
                    if (current == null)
                    {
                        return false; // Список слишком короткий
                    }
                    current = current.Next;
                }

                // Проверяем, что нашли нужное место для вставки
                if (current == null)
                {
                    return false; // Список слишком короткий
                }

                // Вставляем новый узел в список
                newNode.Next = current.Next;
                current.Next = newNode;
                return true;
            }
        }
    }
}
