﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Intermediarios_CSharp_II__Maior_e_Posicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int maior = 0;
            int posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            Console.ReadKey();
        }
    }
}
