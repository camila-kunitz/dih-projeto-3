using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaInvestimento : ContaBancaria
    {
        public TipoInvestimentoEnum tipoInvestimento { get; set; }
        public ContaInvestimento(int numeroConta, AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal, double saldo) : base(numeroConta, numeroAgencia, cliente, rendaMensal, saldo)
        {
        }
    }
}
