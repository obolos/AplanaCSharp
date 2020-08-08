
// Задание №22
// 1. Массив размерностью 20, заполняется случайными целыми числами от -10 до 10.
// Найти максимальный отрицательный и минимальный положительный элементы массива.
// Поменять их местами.
// 2. Формируется новогодний подарок.
// Он может включать в себя разные сладости (Candy, Jellybean, etc.)
// У каждой сладости есть название, вес, цена и свой уникальный параметр.
// Необходимо собрать подарок из сладостей.
// Найти общий вес подарка, общую стоимость подарка и вывести на консоль информацию о всех сладостях в подарке.

using System;
using System.Linq;

namespace AplanaCSharp
{
    public class Task22
    {
        public Task22()
        {
            Helper.Init();
        }

        public void randArray()
        {
            int[] array = new int[20];
            var rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = rand.Next(-10, 11);
            }

            int max = array.Max();
            int maxIndex = Array.IndexOf(array, max);

            int min = array.Min();
            int minIndex = Array.IndexOf(array, min);

            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
            
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }

            int tmp = array[minIndex];
            array[minIndex] = array[maxIndex];
            array[maxIndex] = tmp;
            
            Console.WriteLine();
            
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
        }
        
    //    2. Формируется новогодний подарок.
    
        public void happyNewYear()
        {

        }

        private void sweetGenerator()
        {
            var rand = new Random();
            string[] array = new[]
            {
                "Cupcake", "Donut", "Eclair", "Froyo", "Gingerbread", "Honeycomb", "Ice Cream Sandwich", "Jelly Bean",
                "KitKat", "Lollipop", "Marshmallow", "Nougat", "Oreo", "Pie"
            };
            var s = array[rand.Next(0, array.Length - 1)];
            Console.WriteLine(s);

            var next = rand.NextDouble();

            double result =  1.41421 + (next * (1.14159 - 0.41421));
            string formattedNumber = result.ToString("0.00");
            Console.WriteLine(formattedNumber + "$");

        }
        

        enum Color
        {
            White,
            Black,
            Green,
            Blue
        }
        
        
        class Sweet
        {
            private string name;
            private double weight;
            private double price;
            private Color color;


            public Sweet(string name, double weight, double price, params Color[] colors)
            {
                this.name = name;
                this.weight = weight;
                this.price = price;
                
            }
        }
    }
}