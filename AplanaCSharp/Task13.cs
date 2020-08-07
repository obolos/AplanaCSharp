
// Задание №13
// Написать программу сортировки по возрастанию заданного пользователем массива чисел.
// Использовать пузырьковый метод сортировки.

using System;

namespace AplanaCSharp
{
    public class Task13
    {
        public Task13()
        {
            Helper.Init();
        }

        public void BubbleSort()
        {
            
            // int[] array = new int[10] {12, 0, 15, -8, 33, 16, 32, 17, 2, 8};
            int[] array = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Заполните {i} элемент массива");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }

            foreach (int a in array)
                Console.Write(a + " ");
            
            
        }
    }
}