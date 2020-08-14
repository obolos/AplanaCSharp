
// Задание №23
// Реализовать калькулятор в стиле ООП. Архитектуру приложения продумать самостоятельно.

using System;

namespace AplanaCSharp
{
    public class Task23
    {
        private Calculator calc;

        public Task23(Calculator calc)
        {
            this.calc = calc;
            calc.calculate();
        }
    }
}