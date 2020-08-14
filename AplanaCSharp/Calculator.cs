using System;

namespace AplanaCSharp
{
    public class Calculator
    {
        private double x;
        private double y;
        private string operation;

        public Calculator() 
        {
            Helper.Init();
        }

        public void calculate()
        {
            while(true)
            {
                Console.WriteLine("Введите значение x ");
                double.TryParse(Console.ReadLine(), out x);
            
                Console.WriteLine("Введите значение y ");
                double.TryParse(Console.ReadLine(), out y);
            
                Console.WriteLine("Выберите операцию для калькулятора: \r\n 1. Сложение \r\n 2. Вычитание \r\n 3. Деление \r\n 4. Умножение");
                this.operation = Console.ReadLine();

                switch (this.operation)
                {
                    case "1":
                    {
                        plus();
                        break;
                    }
                    case "2":
                    {
                        minus();
                        break;
                    }
                    case "3":
                    {
                        devide();
                        break;
                    }
                    case "4":
                    {
                        multiply();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Wrong data");
                        break;
                    }

                }
            }
        }
            
        
        private void plus()
        {
            Console.WriteLine($"{x + y}");
                
        }

        private void minus()
        {
            Console.WriteLine($"{x - y}");
        }

        private void multiply()
        {
            Console.WriteLine($"{x * y}");
        }

        private void devide()
        {
            if (y == 0)
                throw new DivideByZeroException("Деление на ноль");
            
            Console.WriteLine($"{x / y}");
            
        }
    }
    }
