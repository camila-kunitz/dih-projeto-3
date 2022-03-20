using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaInvestimento : ContaBancaria
    {
        public double ValorAplicado { get; private set; }
        public TipoInvestimentoEnum tipoInvestimento { get; private set; }
        public DateTime dataAplicacao { get; private set; }
        public DateTime dataRetirada { get; private set; }
        public double ValorRendimento { get; private set; }

        public ContaInvestimento(AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal) : base(numeroAgencia, cliente, rendaMensal)
        {
            TipoConta = TipoContaEnum.INVESTIMENTO;
        }

        public double SimularInvestimento(double valorAplicado, int mesesAplicado, TipoInvestimentoEnum tipoInvestimento)
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

        public void RealizarInvestimento(double valorAplicado, int mesesAplicado, TipoInvestimentoEnum tipoInvestimento)
        {
            ValorRendimento = SimularInvestimento(valorAplicado, mesesAplicado, tipoInvestimento);
            ValorAplicado = valorAplicado;
            this.tipoInvestimento = tipoInvestimento;
            dataAplicacao = DateTime.Now;
            dataRetirada = dataAplicacao.AddMonths(mesesAplicado);
        }

        public override void ConsultarExtrato()
        {
            Console.WriteLine($"Extrato do investimento da conta: {NumeroConta} | cliente: {cliente.Nome}");
            Console.WriteLine($">>> Data da aplicação: {dataAplicacao} | Data da retirada: {dataRetirada} | Tipo: {tipoInvestimento} | Valor Aplicado: R$ {ValorAplicado} | Valor Rendido: R$ {ValorRendimento}");
        }

    }
}
