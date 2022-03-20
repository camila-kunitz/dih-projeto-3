using DEVInBank.Core.Entities;
using DEVInBank.Core.Entities.Enum;
using System;

namespace DEVInBankConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria dados fictícios de clientes, contas e transferências
            var contasBancarias = DadosMock.ContasBancarias;
            DadosMock.ExecutarTransferencias();

            Console.WriteLine(">>>>>> Bem Vindo ao DEVInBank <<<<<< \n");


            criarMenu();
        }

        private static void criarMenu()
        {
            Console.WriteLine("1 - Listar todas as contas.");
            Console.WriteLine("2 - Listar contas com saldo negativo.");
            Console.WriteLine("3 - Listar total de valor investido.");
            Console.WriteLine("4 - Listar todas as transações de um determinado cliente. \n");

            var opcaoDigitada = Console.ReadLine();

            switch (opcaoDigitada)
            {
                case "1":
                    Console.WriteLine(">> 1");
                    break;

                case "2":
                    Console.WriteLine(">> 2");
                    break;

                case "3":
                    Console.WriteLine(">> 3");
                    break;

                case "4":
                    Console.WriteLine(">> 4");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Selecione uma operação:");
                    criarMenu();
                    break;
            }
        }
   
    }
}
    