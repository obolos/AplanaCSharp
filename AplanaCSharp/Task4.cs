
// Задание №4
// Написать программу, которая будет выполнять следующие действия:
// 1. Ввод трех чисел с клавиатуры x, y, z
// 2. Нахождение и вывод на экран среднего арифметического чисел x, y, z
// 3. Деление среднего арифметического на 2 без остатка 
// 4. Если полученное число больше 3, то вывести на экран сообщение "Программа выполнена корректно"

using System;

namespace AplanaCSharp
{
    public class Task4
    {
        public Task4()
        {
            Helper.Init();
        }

        public void AvgNumber()
        {
            Console.WriteLine("Введите число x");
            int x = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите число y");
            int y = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите число z");
            int z = Int32.Parse(Console.ReadLine());

            double avg = (double)(x + y + z) / 3;
            Console.WriteLine($"Среднее чисел равно: {avg}");
            
            if ((avg % 2 == 0) && (avg > 3))
                Console.WriteLine("Программа выполнена корректно");
        }
    }
}