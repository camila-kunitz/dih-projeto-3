using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numeroConta, AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal, double saldo) : base(numeroConta, numeroAgencia, cliente, rendaMensal, saldo)
        {
        }
    }
}
