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
    }
}
