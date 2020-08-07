
// Задание №8
// Произведите ввод данных с клавиатуры в матрицу,
// а после этого произведите вывод первой строки матрицы на экран,
// где каждый элемент умножается на 3.
// Размерность матрицы задается пользователем.

using System;

namespace AplanaCSharp
{
    public class Task8
    {
        public Task8()
        {
            Helper.Init();
        }

        public void MatrixMultiply()
        {
            Console.WriteLine("Введите кол-во строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int m = int.Parse(Console.ReadLine());
            var array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Введите {i} : {j} элемент массива");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            for(int i = 0; i < m; i++)
                Console.Write(array[0, i] + " ");
        }
    }
}