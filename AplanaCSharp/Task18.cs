
// Задание №18
// Написать программу сортировки по возрастанию заданного пользователем массива чисел.
// Пользователь программы должен задавать размер массива и наполнять его числами.
// Использовать одну из следующих сортировок: прямого выбора, вставки, быстрая, Шелла.

using System;

namespace AplanaCSharp
{
    public class Task18
    {
        public Task18()
        {
            Helper.Init();
        }

        public void ArraySort()
        {
            Console.WriteLine("Введите размерность для массива чисел");
            int len = int.Parse(Console.ReadLine());
            var array = new int[len];

            Console.WriteLine("Заполните массив числами");
            for (int i = 0; i < array.Length; i++) array[i] = int.Parse(Console.ReadLine());

            foreach (var a in array) Console.Write($"{a} ");
            ShellSort(array);
            Console.WriteLine();
            foreach (var a in array) Console.Write($"{a} ");

        }
        
        private void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }

        private int[] ShellSort(int[] array)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
        }
    }
}