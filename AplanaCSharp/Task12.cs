
// Задание №12
// Необходимо написать программу, которая будет реализовывать следующие действия:
// 1. Ввод числа с клавиатуры и запись его в строковую переменную S
// 2. Конвертация строковой переменной S в числовую переменную X типа int
// 3. Конвертация числа X типа int в число Y типа double
// Все три числа разных типов необходимо в столбик вывести на экран

using System;

namespace AplanaCSharp
{
    public class Task12
    {
        public Task12()
        {
            Helper.Init();
        }

        public void ThreeNumbers()
        {
            Console.WriteLine("Введите число");
            string S = Console.ReadLine();
            int X = Convert.ToInt32(S);
            double Y = Convert.ToDouble(X);

            Console.WriteLine(S);
            Console.WriteLine(X);
            Console.WriteLine("{0:N2}", Y);
            

        }
    }
}