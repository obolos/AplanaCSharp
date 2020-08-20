
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
using System.Collections.Generic;
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

            int minPositiveElement = array.OrderBy(i => i).SkipWhile(i => i <= 0).First();
            int minPositiveIndex = Array.IndexOf(array, minPositiveElement);

            int maxNegativeElement = array.Min();
            int maxNegativeIndex = Array.IndexOf(array, maxNegativeElement);

            Console.WriteLine($"minPositiveElement = {minPositiveElement}");
            Console.WriteLine($"maxNegativeElement = {maxNegativeElement}");
            
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }

            int tmp = array[maxNegativeIndex];
            array[maxNegativeIndex] = array[minPositiveIndex];
            array[minPositiveIndex] = tmp;

            Console.WriteLine();
            
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
            
        }
        
    //    2. Формируется новогодний подарок.
    
        public void happyNewYear()
        {
            // создать несколько объектов - экземпляров этого класса с различными значениями данных параметров
            List<Sweet> gift= new List<Sweet>();
            double summa = 0;
            double summWeight = 0;
            
            Console.WriteLine("Укажите количество сладостей для этого подарка");
            int sweets = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < sweets; i++)
            {
                gift.Add(sweetGenerator());
            }

            Console.WriteLine("Подарок сформирован: ");
            // вывести на консоль информацию о всех сладостях в подарке
            foreach (var d in gift)
            {
                Console.WriteLine(d);
                summa += d.Price;
                summWeight += d.Weight;
            }
            
            // Найти общий вес подарка, общую стоимость подарка
            Console.WriteLine($"общий вес подарка {summWeight.ToString("0.00")} \nОбщая стоимость подарка {summa.ToString("0.00") + "$"}");
            
        }

        private Sweet sweetGenerator()
        {
            var rand = new Random();
            string[] array = new[]
            {
                "Cupcake", "Donut", "Eclair", "Froyo", "Gingerbread", "Honeycomb", "Ice Cream Sandwich", "Jelly Bean",
                "KitKat", "Lollipop", "Marshmallow", "Nougat", "Oreo", "Pie"
            };
            var sweetName = array[rand.Next(0, array.Length - 1)];
            var next = rand.NextDouble();

            double price =  1.41421 + (next * (1.14159 - 0.41421));
            double weight =  0.4 + (next * (0.7 - 0.4));
            int id = rand.Next(0, 9999999); // свой уникальный параметр

            return new Sweet(sweetName, weight, price, id);
        }

        class Sweet
        {
            private string name;
            private double weight;
            private double price;
            private int ID;


            public Sweet(string name, double weight, double price, int id)
            {
                this.name = name;
                this.weight = weight;
                this.price = price;
                this.ID = id;

            }
            
            public double Weight
            {
                get { return weight; }
            }
            
            public double Price
            {
                get { return price; }
            }

            public override string ToString()
            {
                return "Название сладости " + name + 
                       "\nВес: " + weight.ToString("0.00") +
                       "\nЦена: " + price.ToString("0.00") + "$" +
                       "\nУникальный параметр ID: " + ID;
            }
        }
    }
}