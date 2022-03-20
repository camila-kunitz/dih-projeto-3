using DEVInBank.Core.Entities;
using DEVInBank.Core.Entities.Enum;

namespace DEVInBankConsole
{
    public class Mock
    {

        public static List<ContaBancaria> ContasBancarias = GetContasBancarias();

        private static List<ContaBancaria> GetContasBancarias()
        {
            var contasBancarias = new List<ContaBancaria>();

            // Conta Corrente
            var enderecoCliente1 = new Endereco("Rua X", "123", "Bairro Y", "00.000-01", "Florianópolis", "SC");
            var cliente1 = new Cliente("Camila", "000.000.000-01", enderecoCliente1);
            var contaCliente1 = new ContaCorrente(AgenciaEnum.FLORIANOPOLIS, cliente1, 1000);
            contaCliente1.Depositar(500);
            contaCliente1.Depositar(300);
            contaCliente1.Sacar(200);

            // Conta Poupança
            var enderecoCliente2 = new Endereco("Rua Z", "456", "Bairro W", "00.000-02", "Biguaçú", "SC");
            var cliente2 = new Cliente("João", "000.000.000-02", enderecoCliente2);
            var contaCliente2 = new ContaPoupanca(AgenciaEnum.BIGUACU, cliente2, 2000);
            contaCliente2.Depositar(1000);
            contaCliente2.Sacar(500);
            var novoEnderecoCliente2 = new Endereco("Rua A", "769", "Bairro B", "00.000-03", "São José", "SC");
            contaCliente2.AlterarDadosCadastrais("João da Silva", novoEnderecoCliente2, 3000, AgenciaEnum.SAO_JOSE);

            // Conta Investimento
            var enderecoCliente3 = new Endereco("Rua 3", "003", "Bairro 3", "00.000-03", "Biguaçú", "SC");
            var cliente3 = new Cliente("Maria da Paz", "000.000.000-03", enderecoCliente3);
            var contaCliente3 = new ContaInvestimento(AgenciaEnum.BIGUACU, cliente3, 3000, TipoInvestimentoEnum.LCA);

            contasBancarias.Add(contaCliente1);
            contasBancarias.Add(contaCliente2);
            contasBancarias.Add(contaCliente3);

            return contasBancarias;
        }

        public static void ExecutarTransferencias()
        {
            var transferencia = new Transferencia(ContasBancarias[0], ContasBancarias[1], 800);
            transferencia.ExecutarTransferencia();
        }
    }
}
