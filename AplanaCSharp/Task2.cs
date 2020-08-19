
// Задание №2 
// Ввести с консоли число в бинарном формате.
// Перевести его в десятичный формат, записать в переменную int и вывести на экран.

using System;
namespace AplanaCSharp
{
    class Task2
    {
        public Task2()
        {
            Helper.Init();
        }

        public void BinaryToInt()
        {
        
            Console.WriteLine("Введите число в бинарном формате");
            int number = Convert.ToInt32(Console.ReadLine(), 2);
            Console.WriteLine(number);
        }
    
                
    
    }
}

