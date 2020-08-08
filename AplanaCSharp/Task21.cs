
// Задание №21
// 1. Реализовать базовые операции калькулятора (+,-,/,*) для предыдущего задания
// 2. Поиск максимального элемента в массиве.
// Для начала задать массив слов.Размерность массива произвольна, задается в консоли.
// После чего в консоли вводятся слова в количестве равном заданной длине массива.
// В полученном массиве необходимо найти самое длинное слово. Результат вывести на консоль
// 3. Программа должна выполнять одно из заданий на выбор.
// Если в консоли ввести 1 - запуститься выполнение калькулятора,
// если 2 - поиск максимального слова в массиве.

using System;
using System.Linq;

namespace AplanaCSharp
{
    public class Task21
    {
        public Task21()
        {
            Helper.Init();
        }

        public void menuItems()
        {
            Console.WriteLine("Для запуска калькулятора введите 1 \nдля запуска поиска по массиву слов, введите 2");
            var ch = Console.ReadLine();
            if (ch == "1")
                calculator();
            else if (ch == "2")
                maxWord();
            else
            {
                Console.WriteLine("Вы ничего не выбрали");
                menuItems();
            }
                
        }

        private void maxWord()
        {
            Console.WriteLine("Задайте размер массива");
            
            int size = int.Parse(Console.ReadLine());
            string[] array = new string[size];
            Console.WriteLine("Заполните массив словами");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("максимальное слово в массиве " + array.OrderBy(x => x.Length).ToArray().Last());


        }
        
        private void calculator()
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