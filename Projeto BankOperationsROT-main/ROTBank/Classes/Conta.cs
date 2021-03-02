using System;
using ROTBank.Enums;

namespace ROTBank.Classes
{
    class Conta
    {
        private TipoConta TipoConta { get; set; }

        private string Nome { get; set; }

        private double Saldo { get; set; }

        private double Credito { get; set; }

        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            TipoConta = tipoConta;
            Nome = nome;
            Saldo = saldo;
            Credito = credito;
        }

        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < Credito * .1)
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            Saldo -= valorSaque;
            MensagemAoUsusario(Nome, Saldo);
            return true;
        }

        public void MensagemAoUsusario(string momeUsusario, double saldoConta)
        {
            Console.WriteLine($"O Saldo atual da conta de {momeUsusario} é {saldoConta}");
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;

            MensagemAoUsusario(Nome, Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorDeposito: valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo Conta: " + TipoConta + " | ";
            retorno += "Nome: " + Nome + " | ";
            retorno += "Saldo: R$" + Saldo + " | ";
            retorno += "Credito: R$" + Credito + " | ";
            return retorno;
        }
    }
}
