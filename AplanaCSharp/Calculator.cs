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

        public Calculator(double i, double j)
        {
            x = i;
            y = j;
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
                        Console.WriteLine(plus());
                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine(minus());
                        break;
                    }
                    case "3":
                    {
                        Console.WriteLine(divide());
                        break;
                    }
                    case "4":
                    {
                        Console.WriteLine(multiply());
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
            
        
        public double plus() => x + y;

        public double minus() => x - y;
        

        public double multiply() => x * y;
        

        public double divide()
        {
            if (y == 0)
                throw new DivideByZeroException("Деление на ноль");

            return x / y;

        }
    }
    }
