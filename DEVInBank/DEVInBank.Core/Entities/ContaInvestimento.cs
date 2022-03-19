using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaInvestimento : ContaBancaria
    {
        public TipoInvestimentoEnum tipoInvestimento { get; private set; }
        
        public ContaInvestimento(AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal, TipoInvestimentoEnum tipoInvestimento) : base(numeroAgencia, cliente, rendaMensal)
        {
            this.tipoInvestimento = tipoInvestimento;
        }

        public double SimularInvestimento(double valorAplicado, int mesesAplicado)
        {
            switch (tipoInvestimento)
            {
                case TipoInvestimentoEnum.LCI:
                    if (mesesAplicado < 6)
                    {
                        throw new Exception("Tempo de aplicação inválido! Tempo mínimo de 6 meses para LCI.");
                    }

                    return valorAplicado * mesesAplicado * 0.08;

                case TipoInvestimentoEnum.LCA:
                    if (mesesAplicado < 12)
                    {
                        throw new Exception("Tempo de aplicação inválido! Tempo mínimo de 12 meses para LCA.");
                    }

                    return valorAplicado * mesesAplicado * 0.09;

                case TipoInvestimentoEnum.CDB:
                    if (mesesAplicado < 36)
                    {
                        throw new Exception("Tempo de aplicação inválido! Tempo mínimo de 12 meses para LCA.");
                    }

                    return valorAplicado * mesesAplicado * 0.10;

                default:

                    throw new Exception("O tipo e o período de aplicação não foi especificado!");
            }
        } 
    }
}
