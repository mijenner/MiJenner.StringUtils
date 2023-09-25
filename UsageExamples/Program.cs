using System;
using MiJenner; 

namespace UsageExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = @"""Rockets are cool. There’s no getting around that."" – Elon Musk";
            Console.WriteLine(str);
            Console.WriteLine("Words in above: " + StringUtils.CountWords(str));


        }
    }
}
