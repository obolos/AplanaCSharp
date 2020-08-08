
// Задание №20
// 1. Начинаем писать калькулятор:
// Реализовать сложение дробных чисел, которые пользователь вводит в консоль.
// Использовать комментарии и JavaDoc при описании метода.
// Использовать форматирование при выводе результата в консоль.
// Полученный результат округлять до 4-х знаков после запятой.
// 2. Запушить проект в свой репозиторий на GitHub
// *Добавить возможность выбора другой операции (сложение, вычитание, деление, умножение)

using System;

namespace AplanaCSharp
{
    public class Task20
    {
        public Task20()
        {
            Helper.Init();
        }

        public void calculator()
        {
            Console.WriteLine("Введите число a ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b ");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию вычисления: 1 - сложение 2 - вычитание 3 - деление 4 - умножение");
            string result = Console.ReadLine();
            
            switch (result)
            {
                case "1":
                    Console.WriteLine(string.Format("{0:0.0000}", a + b));
                    break;
                case "2":
                    Console.WriteLine(string.Format("{0:0.0000}", a - b));
                    break;
                case "3":
                    if (b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                        break;
                    }
                    Console.WriteLine(string.Format("{0:0.0000}", a / b));
                    break;
                case "4":
                    Console.WriteLine(string.Format("{0:0.0000}", a * b));
                    break;
            }
           
        }
    }
}