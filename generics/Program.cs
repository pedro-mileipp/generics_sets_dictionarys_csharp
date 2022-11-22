using System;
using Entities;

/*

Problema Motivador 1 (reuso): Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de 1 a 10), e depois imprima esses números de forma organizada conforme exemplo. Em seguida, informar qual foi o primeiro valor informado.

How many values? 3
8
23
[10, 8, 23]
First: 10

*/

namespace Course {
    class Program {
        static void Main(string[] args) {

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());

            // O problema de fazer dessa forma (no PrintService como int) é que são aceitos apenas números inteiros, se eu quisesse entrar com strings não seria possível
            // Aí entra o problema do reuso, dessa forma o PrintService só funciona com apenas 1 tipo de dado.
            // Usar object tira o type safety e afeta a perfomance do código.
            // Com o Generics todos os problemas serao resolvidos, representado pelo tipo T em PrintService


        }
    }
}