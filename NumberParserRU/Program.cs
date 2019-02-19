using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NumberParserRU
{
    class Program
    {
        static void Main()
        {
            using (var parser = ParserFactory.CreateDefault())
            {
                Console.WriteLine(parser.SumProp(12345678901, "М", "И"));
                Console.WriteLine(parser.SumProp(12345678901, "Ж", "И"));
                Console.WriteLine(parser.SumProp(12345678901, "М", "Т"));
                Console.WriteLine(parser.SumProp(12345678901, "Ж", "Т"));

                Console.WriteLine(parser.SumProp(31, "М", "Р"));
                Console.WriteLine(parser.SumProp(22, "С", "Т"));
                Console.WriteLine(parser.SumProp(154323, "М", "И"));
                Console.WriteLine(parser.SumProp(154323, "М", "Т"));
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
