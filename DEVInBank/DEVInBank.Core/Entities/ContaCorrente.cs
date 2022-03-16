using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaCorrente : ContaBancaria
    {
        public double ChequeEspecial { get; set; }

        public ContaCorrente(int numeroConta, AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal, double saldo) : base(numeroConta, numeroAgencia, cliente, rendaMensal, saldo)
        {

        }
    }
}
