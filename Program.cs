﻿/* Codigo feinto pelo Afonsope */

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_and_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;

            double media;

            string nome1;

            Console.Write("Qual seu nome? :");
            nome1 = Console.ReadLine();

            Console.Write($"{nome1} qual foi sua nota no 1° bimestre? :");
            n1 = int.Parse(Console.ReadLine());

            Console.Write($"{nome1} qual foi sua nota no 2° bimestre? :");
            n2 = int.Parse(Console.ReadLine());

            Console.Write($"{nome1} qual foi sua nota no 3° bimestre? :");
            n3 = int.Parse(Console.ReadLine());

            Console.Write($"{nome1} qual foi sua nota no 4° bimestre? :");
            n4 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"A media desse numeros é: {media}");
            Console.ReadLine();

            if (media < 4)
            {
                Console.Write("REPROVADO!");
                Console.ReadLine();
            }

            if (media < 7)
            {
                Console.Write("ESTA DE EXAME!");
                Console.ReadLine();
            }

            else
            {
                Console.Write("APROVADO!");
                Console.ReadLine();

            }

            Console.Write("Precisa de mais alguma coisa burro? (s/n):");
            Console.Read();

            Console.Write("to nem ai, não vou fazer nda não!");
            Console.ReadKey();
        }
    }
}
