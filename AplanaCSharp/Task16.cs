
// Задание №16
// Необходимо написать программу, которая будет выводить на экран текстовые данные из файла .txt,
// а потом в этот же файл перезаписывать текстовые данные, введенные вручную.
// Количество строк после перезаписи должно быть столько же, сколько и в изначальном варианте.

using System;
using System.IO;
using System.Text;

namespace AplanaCSharp
{
    public class Task16
    {
        public Task16()
        {
            Helper.Init();
        }

        public void stringReminder()
        {
           int count;
            
            string path = Directory
                .GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName)
                .FullName;
            path += @"\Task16.txt";

            Console.WriteLine("Считывание из файла");
            readTextData(path, out count);
            Console.WriteLine("Введите текст");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(Console.ReadLine() + "\n");
            }
            writeTextData(path, sb.ToString());
        }

        private void readTextData(string path, out int count)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    Console.WriteLine(line);
                }
            }
        }

        private void writeTextData(string writePath, string sb)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(sb);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}