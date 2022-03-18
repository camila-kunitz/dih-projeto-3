using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaCorrente : ContaBancaria
    {
        public double LimiteChequeEspecial { get; private set; }

        public ContaCorrente(AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal) : base(numeroAgencia, cliente, rendaMensal)
        {
            LimiteChequeEspecial = RendaMensal * 0.10;
        }

        public override void Sacar(double valorSacado)
        {
            if (valorSacado <= (saldo + LimiteChequeEspecial))
            {
                var transacao = new Transacao(TipoTransacaoEnum.SAQUE, valorSacado);
                Transacoes.Add(transacao);

                saldo -= valorSacado;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para esta operação.");
            }
        }

        public override void EnviarTransferencia(double valorTransferido)
        {
            if (valorTransferido <= (saldo + LimiteChequeEspecial))
            {
                var transacao = new Transacao(TipoTransacaoEnum.TRANSFERENCIA_ENVIADA, valorTransferido);
                Transacoes.Add(transacao);

                saldo -= valorTransferido;
            }
            else
            {
                throw new Exception("Saldo insuficiente para esta operação.");
            }
        }
    }
}
