using System;

namespace Program {

    class LO004 {

        static void Main() {
            double ValorDaNotaFiscal = 7000.0;
            double Calculo;

            if (ValorDaNotaFiscal <= 999) {
                Calculo = (ValorDaNotaFiscal * 2) / 100;
                ValorDaNotaFiscal = ValorDaNotaFiscal + Calculo;

                Console.WriteLine(ValorDaNotaFiscal);
            } else if ((ValorDaNotaFiscal >= 1000) && (ValorDaNotaFiscal <= 2999)) {
                Calculo = (ValorDaNotaFiscal * 2.5) / 100;
                ValorDaNotaFiscal = ValorDaNotaFiscal + Calculo;

                Console.WriteLine(ValorDaNotaFiscal);
            } else if ((ValorDaNotaFiscal >= 3000) && (ValorDaNotaFiscal <= 6999)) {
                Calculo = (ValorDaNotaFiscal * 2.8) / 100;
                ValorDaNotaFiscal = ValorDaNotaFiscal + Calculo;

                Console.WriteLine(ValorDaNotaFiscal);
            } else if (ValorDaNotaFiscal >= 7000) {
                Calculo = (ValorDaNotaFiscal * 3.0) / 100;
                ValorDaNotaFiscal = ValorDaNotaFiscal + Calculo;

                Console.WriteLine(ValorDaNotaFiscal);
            }
        }

    }

}