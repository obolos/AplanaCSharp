
// Задание №9
// Необходимо произвести ввод строки с клавиатуры и записать в строковую переменную.
// Результат вывести на экран. 

using System;
using System.Text;

namespace AplanaCSharp
{
    public class Task9
    {
        public Task9()
        {
            Helper.Init();
        }

        public void ConsoleText()
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            Console.WriteLine(text);
        }
    }
}