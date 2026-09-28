<<<<<<< HEAD
﻿using System.ComponentModel;
=======
﻿using System.IO.Pipelines;
using System.Net.Quic;
>>>>>>> 3be7c5be85a33d701334c0c27ca341a00ffcb7f6
using System.Xml;

namespace Introducao_CSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao sistema.");

        //* Entrada de dados
        Console.WriteLine("Digite Seu nome:");

        string nome = Console.ReadLine();
        Console.WriteLine($"{nome}, Digite sua idade");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n Ola {nome}, tudo bem? vi que sua idade é {idade} anos.");

        if (idade < 18)
        {
            Console.WriteLine($"Ops, {nome} voce ainda é menor de idade");

        }

        else
        {
            Console.WriteLine($"{nome}, voce ja e maior de idade");
        }

        //* Menu
        Console.WriteLine($"\n {nome} digite o numero que corresponde a sua escolha");
        Console.WriteLine("1- ver a taboada de um numero");
        Console.WriteLine("2- Contar ate um numero");
<<<<<<< HEAD
        Console.WriteLine("3- sair");
        Console.WriteLine("4- Fibonacci");
=======
        Console.WriteLine("3- fibonacci");
        Console.WriteLine("4- sair");
>>>>>>> 3be7c5be85a33d701334c0c27ca341a00ffcb7f6

        Console.WriteLine($"{nome}, Digite a sua opcao");

        int opcao = int.Parse(Console.ReadLine());
        int numeroDig = int.Parse(Console.ReadLine());
        
        switch (opcao)
        {
<<<<<<< HEAD
            Console.WriteLine($"OK {nome}, voce escolheu {opcao}... então digite um numero para taboada");
        }

        else if (opcao == 2)
        {
            Console.WriteLine($"OK {nome}, voce escolheu {opcao}... então escolha um numero para contagem");
        }

        else if (opcao == 3)
        {
            Console.WriteLine($" Ok {nome}, voce escolheu {opcao}... então saindo...");
            return;
        }

        else if (opcao == 4)
        {
            Console.WriteLine($"{nome} digite o numero de vezes que deseja que a operação seja feita...");
            int numeroVezes = int.Parse(Console.ReadLine());

            int valorInicial = 0; // a
            int valorAtual = 1; // b
            int proximoValor = 0; // c

            if (numeroVezes >= 1 && numeroVezes <= 100)
            {
                for (int i = 0; i <= numeroVezes; i++)
                {
                    proximoValor = valorInicial + valorAtual; // c = a + b
                    valorInicial = valorAtual; // a = b
                    
                    Console.WriteLine(proximoValor);  // Escreve
                    
                    valorAtual = proximoValor; // atualiza b = c
                }
            }
=======
            case 1:
                Console.WriteLine("Digite um numero");
                numeroDig = int.Parse(Console.ReadLine());
                if (numeroDig < 1)
                {
                    Console.WriteLine($"O numero digitado precisa sem maior que 0");
                }

                else
                {
                    int multiplicador;
                    int resultado;

                    for (int i = 1; i < 10; i++)
                    {
                        multiplicador = i;
                        resultado = numeroDig * multiplicador;

                        Console.WriteLine($"{numeroDig}X{multiplicador} = {resultado}");
                    }
                }
            break;

            case 2:
                Console.WriteLine("Digite um numero para contagem");
                numeroDig = int.Parse(Console.ReadLine());
                if (numeroDig < 1)
                {
                    Console.WriteLine($"O numero digitado precisa sem maior que 0");
                }

                else

                {
                    for (int i = 0; i >= numeroDig; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            break;

            case 3:
                numeroDig = int.Parse(Console.ReadLine());
                int valorInicial = 0;
                int valorAtual = 1;
                int ValorTotal = valorInicial + valorAtual;
                Console.WriteLine("Digite um numero para iniciar");

                if (numeroDig < 1)
                {
                    Console.WriteLine($"O numero digitado precisa sem maior que 0");
                }

                else
                {
                    for (int i = 0; i < numeroDig; i++)
                    {
                        ValorTotal = valorInicial + valorAtual;

                        Console.WriteLine(ValorTotal);
                        valorInicial = valorAtual;
                        valorAtual = ValorTotal;
                    }
                }
            break;

            case 4:
                Environment.Exit(0);
            break;
>>>>>>> 3be7c5be85a33d701334c0c27ca341a00ffcb7f6
        }
    }
}
