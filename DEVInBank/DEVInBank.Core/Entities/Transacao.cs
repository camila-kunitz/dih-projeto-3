using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class Transacao
    {
        public DateTime DataTransacao { get; set; }
        public TipoTransacaoEnum Tipo { get; set; }
        public double ValorTransacao { get; set; }

        public Transacao(DateTime dataTransacao, TipoTransacaoEnum tipo, double valorTransacao)
        {
            DataTransacao = dataTransacao;
            Tipo = tipo;
            ValorTransacao = valorTransacao;
        }
    }
}
