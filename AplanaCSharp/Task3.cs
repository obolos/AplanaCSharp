
// Задание №3
// Необходимо вывести на экран таблицу умножения от 1 до 10
// для введённого пользователем любого числа. Использовать циклы запрещено.

using System;

namespace AplanaCSharp
{
    public class Task3
    {
        public Task3()
        {
            Helper.Init();
        }

        public void MultiplicationTable()
        {

            Console.WriteLine("Введите число");
            int number = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
                Console.WriteLine($"{number} * {i} = {i * number}");
        } 
    }
}