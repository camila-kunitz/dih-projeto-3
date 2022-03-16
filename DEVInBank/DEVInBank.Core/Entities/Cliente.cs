namespace DEVInBank.Core.Entities
{
    public class Cliente
    {
        protected string Nome { get; private set; }
        protected string CPF { get; private set; }
        protected Endereco Endereco { get; private set; }

        public Cliente(string nome, string cpf, Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
        }
    }
}
