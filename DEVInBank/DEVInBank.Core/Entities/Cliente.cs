namespace DEVInBank.Core.Entities
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public Endereco Endereco { get; private set; }

        public Cliente(string nome, string cpf, Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
        }

        public void AtualizarNome(string nomeAtualizado)
        {
            Nome = nomeAtualizado;
        }

        public void AtualizarEndereco(Endereco novoEndereco)
        {
            Endereco = novoEndereco;
        }
    }
}
