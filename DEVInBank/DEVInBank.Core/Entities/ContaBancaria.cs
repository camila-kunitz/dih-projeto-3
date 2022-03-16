using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public abstract class ContaBancaria
    {
        protected int NumeroConta { get; private set; }
        protected AgenciaEnum NumeroAgencia { get; private set; }

        public Cliente cliente;
        protected double RendaMensal { get; private set; }
        protected double Saldo { get; private set; }   
        protected List<Transferencia> Transferencias { get; private set; }

        public ContaBancaria(int numeroConta, AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal, double saldo)
        {
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
            this.cliente = cliente;
            RendaMensal = rendaMensal;
            Saldo = saldo;
        }

    }
}
