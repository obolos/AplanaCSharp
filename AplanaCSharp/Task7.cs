
// Задание №7
// Произведите ввод данных с клавиатуры в массив,
// а после этого произведите вывод массива на экран,
// где каждый элемент массива умножается на 2.
// Размер массива задается пользователем.

using System;

namespace AplanaCSharp
{
    public class Task7
    {
        public Task7()
        {
            Helper.Init();
        }

        public void MultiplyArray()
        {
            Console.WriteLine("Задайте размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите значение для элемента: {i+1}");
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach (int elem in array)
            {
                Console.Write(elem * 2 + " ");
            }
        }
    }
}