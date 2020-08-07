
// Задание №5
// Необходимо написать программу,
// где бы пользователю предлагалось ввести с клавиатуры число в переменную number.
// В программе должны присутствовать константы X, Y, Z.
// Программа должна сравнивать введенное значение с клавиатуры со значением констант
// и вывести на экран сообщение "Данное значение имеется в константах"
// если number=X или Y или Z.
// Если переменная отличается от констант, нужно вывести оповещение "Такой константы нет!"

using System;

namespace AplanaCSharp
{
    public class Task5
    {
        public Task5()
        {
            Helper.Init();
        }

        public void ConstOrNot()
        {
           const int X = 10, Y = 15, Z = 20;
            Console.WriteLine("Введите число");
            int number = Int32.Parse(Console.ReadLine());

            if (number == X || number == Y || number == Z)
                Console.WriteLine("Данное значение имеется в константах");
            else
                Console.WriteLine("Такой константы нет!");
            
        }
    }
}