
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
        
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            Console.WriteLine(text);
        }
    
                
    
    }
}

