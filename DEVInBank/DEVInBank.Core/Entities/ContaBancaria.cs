﻿using DEVInBank.Core.Entities.Enum;

namespace DEVInBank.Core.Entities
{
    public class ContaBancaria
    {
        private static int NUMERO_SEQUENCIAL = 0;

        public int NumeroConta { get; private set; }
        public AgenciaEnum NumeroAgencia { get; private set; }
        public Cliente cliente { get; private set; }
        public double RendaMensal { get; private set; }
        private double saldo { get; set; }
        public List<Transacao> Transacoes { get; set; } = new List<Transacao>();

        public ContaBancaria(AgenciaEnum numeroAgencia, Cliente cliente, double rendaMensal)
        {
            NumeroConta = ++NUMERO_SEQUENCIAL;
            NumeroAgencia = numeroAgencia;
            this.cliente = cliente;
            RendaMensal = rendaMensal;
            saldo = 0;
        }

        public double ConsultarSaldo()
        {
            return saldo;
        }

        public void Depositar(double valorDepositado) {
            var transacao = new Transacao(TipoTransacaoEnum.DEPOSITO, valorDepositado);
            Transacoes.Add(transacao);

            saldo += valorDepositado;
        }

        public void Sacar(double valorSacado)
        {
            if (saldo >= valorSacado) {
                var transacao = new Transacao(TipoTransacaoEnum.SAQUE, valorSacado);
                Transacoes.Add(transacao);

                saldo -= valorSacado;
            } else {
                Console.WriteLine("Saldo insuficiente para esta operação.");
            } 
        }

        public void ConsultarExtrato()
        {
            Console.WriteLine($"Extrato de movimentação da conta: {NumeroConta} | cliente: {cliente.Nome}");

            Transacoes.ForEach(transacao => {
                Console.WriteLine($">>> Data da Transação: {transacao.DataTransacao} | Tipo: {transacao.Tipo} | Valor: {transacao.ValorTransacao} ");
            });
        }

        public void AlterarDadosCadastrais(string nomeAtualizado, Endereco novoEndereco, double novaRendaMensal, AgenciaEnum novaAgencia)
        {
            cliente.AtualizarNome(nomeAtualizado);
            cliente.AtualizarEndereco(novoEndereco);
            RendaMensal = novaRendaMensal;
            NumeroAgencia = novaAgencia;
        }

        public void ReceberTransferencia(double valorTransferido)
        {
            var transacao = new Transacao(TipoTransacaoEnum.TRANSFERENCIA_RECEBIDA, valorTransferido);
            Transacoes.Add(transacao);

            saldo += valorTransferido;
        }

        public void EnviarTransferencia(double valorTransferido)
        {
            if (saldo >= valorTransferido)
            {
                var transacao = new Transacao(TipoTransacaoEnum.TRANSFERENCIA_ENVIADA, valorTransferido);
                Transacoes.Add(transacao);

                saldo -= valorTransferido;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para esta operação.");
            }
        }
    }
}
