namespace DEVInBank.Core.Entities
{
    public class Transferencia 
    {
        protected ContaBancaria ContaOrigem { get; private set; }
        protected ContaBancaria ContaDestino { get; private set; }
        protected double Valor { get; private set; }
        public DateTime Data { get; private set; }

        public Transferencia(ContaBancaria contaOrigem, ContaBancaria contaDestino, double valor)
        {
            ContaOrigem = contaOrigem;
            ContaDestino = contaDestino;
            Valor = valor;
            Data = DateTime.Now;
        }

        public Transferencia(ContaBancaria contaOrigem, ContaBancaria contaDestino, double valor, DateTime data)
        {
            ContaOrigem = contaOrigem;
            ContaDestino = contaDestino;
            Valor = valor;
            Data = data;
        }

        public void ExecutarTransferencia()
        {
            try
            {
                if (ContaOrigem.NumeroConta == ContaDestino.NumeroConta)
                {
                    throw new Exception("Não é permitido realizar esta operação para a mesma conta.");
                }

                if (this.Data.DayOfWeek == DayOfWeek.Saturday || this.Data.DayOfWeek == DayOfWeek.Sunday)
                {
                    throw new Exception("Não é permitido realizar esta operação no fim de semana.");
                }

                ContaOrigem.EnviarTransferencia(Valor);
                ContaDestino.ReceberTransferencia(Valor);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
