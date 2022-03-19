using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal) : base(numeroAgencia, cliente, rendaMensal)
        {
        }

        public double SimularRendimento(int meses, double rentabilidade)
        {
            return this.saldo * meses * rentabilidade;
        }

    }
}
