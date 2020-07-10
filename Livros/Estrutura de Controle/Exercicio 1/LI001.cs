using System;

namespace Program {
    class LI001 {
        static void Main() {
            double Saldo = 100.0;
            double ValorSaque = 10.0;

            if (Saldo >= ValorSaque) {
                Saldo -= ValorSaque;
                Console.WriteLine("Saque efetuado com sucesso, seu saldo atual: {0}", Saldo);
            } else {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        /*
        O usuario dejesa efeutuar um saque em o software verifica se o saldo dele é maior que o valor do saque.
        Si o saldo for maior do que o valor do saque, o software retornará uma mensagem de Sucesso caso contrario
        o saque não será efetuado.
        */
        
    }
}