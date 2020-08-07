
// Задание №10
// Для введенной с клавиатуры строки необходимо провести отсев пробелов.
// Результат в виде строки без пробелов вывести на экран. 

using System;
using System.Text;

namespace AplanaCSharp
{
    public class Task10
    {
        public Task10()
        {
            Helper.Init();
        }

        public void WithoutSpaces()
        {
            Console.WriteLine("Введите строку с пробелами");
            string text = Console.ReadLine();
            
            StringBuilder result = new StringBuilder();
            string[] words = text.Split(' ');
            
            foreach (string t in words) 
                result.Append(t.Trim(' '));
            
            Console.Write(result.ToString());

        }
    }
}