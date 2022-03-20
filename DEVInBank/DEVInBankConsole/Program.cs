using DEVInBank.Core.Entities;
using DEVInBank.Core.Entities.Enum;
using System;

namespace DEVInBankConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(">>>>>> Bem Vindo ao DEVInBank <<<<<< \n");

            var contasBancarias = Mock.ContasBancarias;
            Mock.ExecutarTransferencias();

            // Conta: Cliente 1
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Conta: {contasBancarias[0].NumeroConta}");
            Console.WriteLine($"Agência: {contasBancarias[0].NumeroAgencia}");
            Console.WriteLine($"Cliente: {contasBancarias[0].cliente.Nome}");
            Console.WriteLine($"CPF: {contasBancarias[0].cliente.CPF}");
            Console.WriteLine($"Saldo: R$ {contasBancarias[0].ConsultarSaldo()}");
            Console.WriteLine($"Renda Mensal: R$ {contasBancarias[0].RendaMensal}");
            Console.WriteLine("------------------------------------");
            contasBancarias[0].ConsultarExtrato();
            Console.WriteLine("------------------------------------ \n");

            // Conta: Cliente 2
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Conta: {contasBancarias[1].NumeroConta}");
            Console.WriteLine($"Agência: {contasBancarias[1].NumeroAgencia}");
            Console.WriteLine($"Cliente: {contasBancarias[1].cliente.Nome}");
            Console.WriteLine($"CPF: {contasBancarias[1].cliente.CPF}");
            Console.WriteLine($"Saldo: R$ {contasBancarias[1].ConsultarSaldo()}");
            Console.WriteLine($"Renda Mensal: R$ {contasBancarias[1].RendaMensal}");
            Console.WriteLine("------------------------------------");
            contasBancarias[1].ConsultarExtrato();
            Console.WriteLine("------------------------------------");
        }
    }
}
    