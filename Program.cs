using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP5
{
    class Program
    {
        static void Main()
        {
            Converter converter = new Converter
                (
                usd: 0.30583, 
                eur: 0.281437, 
                rub: 27.93
                );

            Console.Write("Count BYN = ");
            double count = int.Parse(Console.ReadLine());

            Console.WriteLine($"{count} BYN = {converter.ConvertToUsd(count)} USD");
            Console.WriteLine($"{count} BYN = {converter.ConvertToEur(count)} EUR");
            Console.WriteLine($"{count} BYN = {converter.ConvertToRub(count)} RUB");


            Console.Write("Count USD/EUR/RUB = ");
            double countRevers = int.Parse(Console.ReadLine());

            Console.WriteLine($"{countRevers} USD = {converter.ConvertReversUsd(countRevers)} BYN");
            Console.WriteLine($"{countRevers} EUR = {converter.ConvertReversEur(countRevers)} BYN");
            Console.WriteLine($"{countRevers} RUB = {converter.ConvertReversRub(countRevers)} BYN");


            Console.ReadKey();
        }
    }
}
