using System;

namespace Program {
    class LI001 {
        static void Main() {
            double Saldo = 5.0;
            double ValorSaque = 10.0;

            if (Saldo >= ValorSaque) {
                Console.WriteLine("Saque efetuado com sucesso");
            } else {
                Console.WriteLine("Saque incompleto, saldo insufuciente");
            }
        }
    }
}