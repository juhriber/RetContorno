﻿using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura, altura;
            int valor1 = 1, valor2 = 1;
            bool larguraValido, alturaValido;

            Console.Write("Digite o Valor de Largura: ");
            larguraValido = int.TryParse(Console.ReadLine(), out largura);
            if (!larguraValido)
            {
                Console.WriteLine();
                Console.WriteLine("Você digitou um valor invalido!");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }
            if (largura < 1 || largura > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Você deve digitar números entre 1 a 10!");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }

            Console.Write("Digite o Valor de Altura: ");
            alturaValido = int.TryParse(Console.ReadLine(), out altura);
            if (!alturaValido)
            {
                Console.WriteLine();
                Console.WriteLine("Você digitou um valor invalido!");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }

            if (altura < 1 || altura > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Você deve digitar números entre 1 a 10!");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }
            Console.WriteLine();

            while (valor1 <= altura)
            {
                while (valor2 <= largura)
                {
                    if (valor2 == 1 || valor2 == largura || valor1 == 1 || valor1 == altura)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    valor2++;
                }
                valor2 = 1;
                Console.WriteLine();
                valor1++;
           }
        }
    }
}
