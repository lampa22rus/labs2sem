using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labs2sem
{
    internal class lab9
    {
        public static void start(int task)
        {
            switch (task)
            {
                case 1:
                    new lab9()._1();
                    break;
                default:
                    Console.WriteLine("Задача не найдена");
                    break;
            }

        }

        public void _1()
        {
            StreamReader reader = new StreamReader("index.html");
            string text = reader.ReadToEnd();
            reader.Close();

            Console.WriteLine("HTML");
            Console.WriteLine("-----");
            Console.WriteLine(text);
            Console.WriteLine("-----");
            Console.WriteLine();
            Console.WriteLine(CheckTags(text) ? "HTML валидный" : "В HTML есть ошибки");

        }

        static bool CheckTags(string input)
        {
            //Создаем стек
            Stack<string> tags = new Stack<string>();
            //Создаем регулярное выражение, которое найдет нам все теги
            Regex tagRegex = new Regex(@"<(/?)(\w+)[^>]*?>");

            //проходимся по тегам
            foreach (Match match in tagRegex.Matches(input))
            {
                //берем тег, гне важно закрывающий он или открывающий
                string tag = match.Groups[2].Value;

                //проверяем, не закрывающийся ли это тег
                bool isClosingTag = match.Groups[1].Value == "/";

                //если не закрывающийся добавляем в стек
                if (!isClosingTag)
                {
                    tags.Push(tag);
                    Console.WriteLine(tag);
                }
                //если закрывающийся и стек пустой - html нарушен, если закрывающийся и при удалении верхнего тега со стека он не будет равен текущему тегу - html нарушен
                else
                {
                    if (tags.Count == 0 || tags.Pop() != tag)
                    {
                        return false;
                    }
                }
            }

            //если в конце окажется что стек не пустой - html нарушен иначе все хорошо
            return tags.Count == 0;
        }
    }
}
