using DEVInBank.Core.Entities;

namespace DEVInBankConsole
{
    class Program
    {
        static List<ContaBancaria> contasBancarias = DadosMock.ContasBancariasMock;

        static void Main(string[] args)
        {
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
                    Console.WriteLine(">> 1 - Relatório de todas as contas:");
                    listarContas();
                    break;

                case "2":
                    Console.WriteLine(">> 2 - Relatório de contas com saldo negativo:");
                    listarContasNegativas();
                    break;

                case "3":
                    Console.WriteLine(">> 3 - Relatório de valores investido:");
                    listarTotalInvestido();
                    break;

                case "4":
                    Console.WriteLine(">> 4 - Relatório de transações:");
                    selecionarCliente();
                    break;

                default:
                    Console.WriteLine("Opção inválida! Selecione uma operação: \n");
                    criarMenu();
                    break;
            }
        }

        private static void listarContas()
        {
            contasBancarias.ForEach(conta => imprimirDetalhesConta(conta));
            criarMenu();
        }

        private static void listarContasNegativas()
        {
            var contasComSaldoNegativo = contasBancarias.Where(conta => conta.ConsultarSaldo() < 0).ToList();
            contasComSaldoNegativo.ForEach(conta => imprimirDetalhesConta(conta));
            criarMenu();
        }

        private static void imprimirDetalhesConta(ContaBancaria conta)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Conta: {conta.NumeroConta}");
            Console.WriteLine($"Agência: {conta.NumeroAgencia}");
            Console.WriteLine($"Tipo da Conta: {conta.TipoConta}");
            Console.WriteLine($"Cliente: {conta.cliente.Nome}");
            Console.WriteLine($"CPF: {conta.cliente.CPF}");
            Console.WriteLine($"Saldo: R$ {conta.ConsultarSaldo()}");
            Console.WriteLine($"Renda Mensal: R$ {conta.RendaMensal}");
            Console.WriteLine("------------------------------------ \n");
        }

        private static void listarTotalInvestido()
        {
            Console.WriteLine("Operação não implementada \n");
            criarMenu();
        }

        private static void selecionarCliente()
        {
            Console.WriteLine("Selecione um cliente: ");
            contasBancarias.ForEach(conta => Console.WriteLine($"{conta.NumeroConta} - {conta.cliente.Nome} "));

            var opcaoSelecionada = Convert.ToInt32(Console.ReadLine());
            var contaSelecionada = contasBancarias.First(conta => conta.NumeroConta.Equals(opcaoSelecionada));

            Console.WriteLine($"\nCliente selecionado: {contaSelecionada.cliente.Nome}");
            contaSelecionada.ConsultarExtrato();
            Console.WriteLine("\n");

            criarMenu(); 
        }
    }
}
    