using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Ввести с клавиатуры предложение.
Предложение представляет собой слова, разделенные пробелом.
Знаки препинания не используются.
Найти самое длинное слово в строке");
            Console.WriteLine("");

            Console.Write("Введите предложение: ");
            string str = Console.ReadLine();

           
            var strings = str.Split(' ');
            
            string LongestWord = "";
            
            foreach (var s in strings)
                 
                if (s.Length > LongestWord.Length) LongestWord = s;

            Console.WriteLine($"Cамое длинное слово: '{LongestWord}'");


            Console.ReadKey();
        }
    }
}
