
// Задание №19
// Ввести с консоли число в бинарном формате.
// Перевести его в десятичный формат, записать в переменную int и вывести на экран.
// Необходимо использовать циклы, нельзя использования готовые методы языка Java,
// для перевода числа из одной системы счисления в другую.

using System;

namespace AplanaCSharp
{
    public class Task19
    {
        public Task19()
        {
            Helper.Init();
        }

        public void binaryFormatSolution()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("Введите число в бинарном формате");
            
            string str1 = Console.ReadLine();
            if (str1 == "")
                throw new Exception("Invalid input");
            int val = 0, res = 0;
            
            for (int i = 0; i < str1.Length; i++) {
                try {
                    val = Int32.Parse(str1[i].ToString());
                    if (val == 1)
                        res += (int)Math.Pow(2, str1.Length - 1 - i);
                    else if (val > 1)
                        throw new Exception("Invalid!");
                } catch {
                    throw new Exception("Invalid!");
                }
            }
            Console.WriteLine(res);
                            
                    
            
        }
    }
}