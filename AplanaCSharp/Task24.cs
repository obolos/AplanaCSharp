
// Задание №24
// Есть входной файл с набором слов, написанных через пробел 
// Необходимо:
// Прочитать слова из файла. 
// Отсортировать в алфавитном порядке.
// Посчитать сколько раз каждое слово встречается в файле.
// Вывести статистику на консоль 
// Найти слово с максимальным количеством повторений.
// Вывести на консоль это слово и сколько раз оно встречается в файле

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AplanaCSharp
{
    public class Task24
    {
        public Task24()
        {
            Helper.Init();
        }

        public void readFile()
        {
            var _filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent("Test.txt").FullName).FullName).FullName).FullName;
            _filePath += @"\WordList.txt";
            Dictionary<string, int> words = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                  
                   string[] str = sr.ReadToEnd().Split(" ");
                   Array.Sort(str);
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Отсортированный: ");
                   Console.ForegroundColor = ConsoleColor.Black;
                   Console.ReadLine();
                   foreach (var s in str) Console.WriteLine(s);
                   
                   Console.ReadLine();
                   foreach (string s in str)
                   {
                       if (!words.ContainsKey(s)) words.Add(s, 1);
                       else words[s]++;
                   }
                   
                   foreach(var word in words) Console.WriteLine("{0} - {1}", word.Key, word.Value);

                   var keyOfMaxValue = words.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                   Console.WriteLine($"слово {keyOfMaxValue} : встречается в файле {words.Values.Max()}" );
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}