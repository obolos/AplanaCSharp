
// Задание №14
// Необходимо написать программу, которая будет выводить на экран текстовые данные из файла .txt

using System;
using System.Collections.Generic;
using System.IO;

namespace AplanaCSharp
{
    public class Task14
    {
        public Task14()
        {
            Helper.Init();
        }

        public void ReadTextData()
        {
            // added the file Test.txt to my test project
            // on the solution explorer hit alt-enter (file properties)
            // there I set BuildAction to Content and Copy to Output Directory to Copy if newer
            
            IEnumerable<string> lines = File.ReadLines(Path.Combine(Environment.CurrentDirectory, "Test.txt"));

            foreach (var line in lines)
                Console.WriteLine(line);
            
        }
    }
}