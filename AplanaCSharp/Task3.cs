
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

            Console.WriteLine("Введите число от 1 до 10!");
            int number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 2:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 3:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 4:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 5:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 6:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 7:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 8:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 9:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                case 10:
                    Console.WriteLine($"{number*1} {number*2} {number*3} {number*4} {number*5} {number*6} {number*7} {number*8} {number*9}");
                    break;
                default:
                    Console.WriteLine("Wrong Way!");
                    break;
            }
                
            
        } 
    }
}