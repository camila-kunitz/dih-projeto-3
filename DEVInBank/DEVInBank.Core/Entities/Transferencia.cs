namespace DEVInBank.Core.Entities
{
    public class Transferencia 
    {
        protected int NumeroContaOrigem { get; private set; }
        protected int NumeroContaDestino { get; private set; }
        protected decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        public Transferencia(int numeroContaOrigem, int numeroContaDestino, decimal valor)
        {
            NumeroContaOrigem = numeroContaOrigem;
            NumeroContaDestino = numeroContaDestino;
            Valor = valor;
            Data = DateTime.Now;
        }

    }
}
