// Задание №6
// Необходимо с помощью цикла вывести на экран числа от 1 до 50.

using System;

namespace AplanaCSharp
{
    public class Task6
    {
        public Task6()
        {
            Helper.Init();
        }

        public void CycleNumbers()
        {
            for (int i = 1; i <= 50; i++)
                Console.WriteLine(i);
        }
    }
}