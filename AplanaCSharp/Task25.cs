
// Задание №25
// Добавить обработку исключений в задание с ООП калькуляторам
// (например, исключение может возникнуть при делении на ноль)

using System;

namespace AplanaCSharp
{
    public class Task25
    {
        private Calculator calc;
        public Task25(Calculator calc)
        {
            try
            {
                calc.calculate();
            }
            catch (DivideByZeroException ex)
            {
                messages(ex);
                calc.calculate();
            }
            
            catch (FormatException ef)
            {
                messages(ef);
                calc.calculate();
            }
            catch (Exception e)
            {
                messages(e);
                calc.calculate();
            }
        }

        private void messages(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Исключение: {ex.Message}");
            Console.WriteLine($"Метод: {ex.TargetSite}");
            Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        
    }
}