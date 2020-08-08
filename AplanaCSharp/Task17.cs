
// Задание №17
// Напишите программу конвертер валют. Программа должна переводить рубли в доллары по текущему курсу.
// Пользователь вводит текущий курс и количество рублей.
// Итоговое значение должно быть округлено до двух знаков после запятой.
// (Пример для теста работы программы: Курс доллара = 67,55, Количество рублей: 1000, Итого: 14,80 долларов)

using System;

namespace AplanaCSharp
{
    public class Task17
    {
        public Task17()
        {
            Helper.Init();
        }

        public void exchanger()
        {
            Console.WriteLine("Введите курс доллара прим. 67.55");
            var cur = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму в рублях прим.1000");
            var rub = Double.Parse(Console.ReadLine());

            Double result = rub / cur;
            Console.WriteLine(string.Format("{0:0.00}", result));

        }
    }
}