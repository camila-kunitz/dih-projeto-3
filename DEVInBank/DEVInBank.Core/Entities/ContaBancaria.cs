using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaBancaria
    {
        private static int NUMERO_SEQUENCIAL = 0;

        public int NumeroConta { get; private set; }
        public AgenciaEnum NumeroAgencia { get; private set; }
        public Cliente cliente { get; private set; }
        public double RendaMensal { get; private set; }
        private double saldo { get; set; }
        public List<Transferencia> Transferencias { get; private set; } = new List<Transferencia>();
        public List<Transacao> Transacoes { get; set; } = new List<Transacao>();

        public ContaBancaria(AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal)
        {
            NumeroConta = ++NUMERO_SEQUENCIAL;
            NumeroAgencia = numeroAgencia;
            this.cliente = cliente;
            RendaMensal = rendaMensal;
            saldo = 0;
        }

        public double ConsultarSaldo()
        {
            return saldo;
        }

        public void Depositar(double valorDepositado) {
            var transacao = new Transacao(DateTime.Now, TipoTransacaoEnum.DEPOSITO, valorDepositado);
            Transacoes.Add(transacao);

            saldo += valorDepositado;
        }

        public void Sacar(double valorSacado)
        {
            if (saldo >= valorSacado) {
                var transacao = new Transacao(DateTime.Now, TipoTransacaoEnum.SAQUE, valorSacado);
                Transacoes.Add(transacao);

                saldo -= valorSacado;
            } else {
                Console.WriteLine("Saldo insuficiente para esta operação.");
            } 
        }

        public void ConsultarExtrato()
        {
            Console.WriteLine($"Extrato de movimentação da conta: {NumeroConta} | cliente: {cliente.Nome}");

            Transacoes.ForEach(transacao => {
                Console.WriteLine($">>> Data da Transação: {transacao.DataTransacao} | Tipo: {transacao.Tipo} | Valor: {transacao.ValorTransacao} ");
            });
        }
    }
}
