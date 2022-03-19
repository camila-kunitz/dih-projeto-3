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

            // Conta Corrente
            var enderecoCliente1 = new Endereco("Rua X", "123", "Bairro Y", "00.000-01", "Florianópolis", "SC");
            var cliente1 = new Cliente("Camila", "000.000.000-01", enderecoCliente1);
            var contaCliente1 = new ContaCorrente(AgenciaEnum.FLORIANOPOLIS, cliente1, 1000);
            contaCliente1.Depositar(500);
            contaCliente1.Depositar(300);
            contaCliente1.Sacar(200);

            // Conta Poupança
            var enderecoCliente2 = new Endereco("Rua Z", "456", "Bairro W", "00.000-02", "Biguaçú", "SC");
            var cliente2 = new Cliente("João", "000.000.000-02", enderecoCliente2);
            var contaCliente2 = new ContaPoupanca(AgenciaEnum.BIGUACU, cliente2, 2000);
            contaCliente2.Depositar(1000);
            contaCliente2.Sacar(500);
            var novoEnderecoCliente2 = new Endereco("Rua A", "769", "Bairro B", "00.000-03", "São José", "SC");
            contaCliente2.AlterarDadosCadastrais("João da Silva", novoEnderecoCliente2, 3000, AgenciaEnum.SAO_JOSE);
            // Conta Poupança - Rendimento
            var rendimentoPoupanca = contaCliente2.SimularRendimento(6, 0.05);

            // Conta Investimento
            var enderecoCliente3 = new Endereco("Rua 3", "003", "Bairro 3", "00.000-03", "Biguaçú", "SC");
            var cliente3 = new Cliente("Maria da Paz", "000.000.000-03", enderecoCliente3);
            var contaCliente3 = new ContaInvestimento(AgenciaEnum.BIGUACU, cliente3, 3000, TipoInvestimentoEnum.LCA);
            var rendimentoInvestimento = contaCliente3.SimularInvestimento(1000, 12);
            Console.WriteLine($"Simulação do Investimento: R$ {rendimentoInvestimento}");


            // Transferência
            var transferencia = new Transferencia(contaCliente1, contaCliente2, 800);
            transferencia.ExecutarTransferencia();

            // Conta: Cliente 1
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Conta: {contaCliente1.NumeroConta}");
            Console.WriteLine($"Agência: {contaCliente1.NumeroAgencia}");
            Console.WriteLine($"Cliente: {contaCliente1.cliente.Nome}");
            Console.WriteLine($"CPF: {contaCliente1.cliente.CPF}");
            Console.WriteLine($"Saldo: R$ {contaCliente1.ConsultarSaldo()}");
            Console.WriteLine($"Limite Cheque Especial: R$ {contaCliente1.LimiteChequeEspecial}");
            Console.WriteLine($"Renda Mensal: R$ {contaCliente1.RendaMensal}");
            Console.WriteLine("------------------------------------");
            contaCliente1.ConsultarExtrato();
            Console.WriteLine("------------------------------------ \n");

            // Conta: Cliente 2
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Conta: {contaCliente2.NumeroConta}");
            Console.WriteLine($"Agência: {contaCliente2.NumeroAgencia}");
            Console.WriteLine($"Cliente: {contaCliente2.cliente.Nome}");
            Console.WriteLine($"CPF: {contaCliente2.cliente.CPF}");
            Console.WriteLine($"Saldo: R$ {contaCliente2.ConsultarSaldo()}");
            Console.WriteLine($"Renda Mensal: R$ {contaCliente2.RendaMensal}");
            Console.WriteLine("------------------------------------");
            contaCliente2.ConsultarExtrato();
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Rendimento Poupança em 6 meses: {rendimentoPoupanca}");
            Console.WriteLine("------------------------------------ \n");









        }
    }
}
    