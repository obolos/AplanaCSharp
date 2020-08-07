
// Задание №15
// Необходимо написать программу, которая будет записывать текстовые данные,
// введенные с экрана, в файл .txt.
// Запись ввести в файл до тех пор, пока не будет введена команда стоп в консоли.
// Пользователь при тестировании программы по правилу черного ящика должен понимать,
// какой принцип остановки записи в файл он должен подать.

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace AplanaCSharp
{
    public class Task15
    {
        public Task15()
        {
            Helper.Init();
        }

        public void WriteNote()
        {
            var _filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent("Test.txt").FullName).FullName).FullName).FullName;
            _filePath += @"\Test.txt";
            Console.WriteLine("Введите текст для записи в файл, как закончите введите Стоп");

            while (true)
            {
                string str = Console.ReadLine();
                if (stopword(word: "стоп", str)) return;
                writeFile(filename: _filePath, str);
            }
                
        }

        private void writeFile(string filename, string str)
        {
            Stream fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            
            try
            { 
                byte[] strInBytes = Encoding.UTF8.GetBytes($"{str}\n");
               fs.Write(strInBytes,0, strInBytes.Length);
               fs.Flush();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
            finally
            {
                fs.Close();
            }

        }

        private bool stopword(string word, string str)
        {
            
            Regex regex = new Regex($"{word}", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(str); 
            return matches.Count > 0;

        }
    }
}