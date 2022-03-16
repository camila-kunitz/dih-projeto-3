using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaInvestimento : ContaBancaria
    {
        public TipoInvestimentoEnum tipoInvestimento { get; set; }
        public ContaInvestimento(AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal) : base( numeroAgencia, cliente, rendaMensal)
        {
        }
    }
}
