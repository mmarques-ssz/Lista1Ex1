﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int b;
            int h;
            int a;
            // Entrada dos dados
            Console.Write("Informe a base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe a altura: ");
            h = int.Parse(Console.ReadLine());
            // Operação aritmética
            a = b * h;

            // Console.Write("O valor da área é ");
            // Console.WriteLine(a);

            // Exibição do resultado
            Console.WriteLine("O valor da área de um retângulo que tem base {0} e altura {1} é {2}", b, h, a);


        }
    }
}
