
// Задание №11
// Необходимо провести сравнение длины двух строк,
// которые были введены с клавиатуры и записаны в соответствующие переменные.
// Вывести на экран строку с наибольшей длиной.
// Если длины равны, вывести соответствующее сообщение.

using System;

namespace AplanaCSharp
{
    public class Task11
    {
        public Task11()
        {
            Helper.Init();
        }

        public void StringsEq()
        {
            Console.WriteLine("Введите строку №1");
            string str1 = Console.ReadLine();
            
            Console.WriteLine("Введите строку №2");
            string str2 = Console.ReadLine();

            if (str1.Length == str2.Length)
                Console.WriteLine("Длина строк одинакова");
            else if (str1.Length > str2.Length)
                Console.WriteLine(str1);
            else
                Console.WriteLine(str2);
        }
    }
}