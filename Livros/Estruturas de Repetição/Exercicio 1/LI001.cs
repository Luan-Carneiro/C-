using System;

namespace Program {
    class li001 {
        static void Main() {
            int total = 2;

            for (int i = 0; i < 5; i += 1) {
                total = total * 2;
            }

            Console.WriteLine("O total é {0}!", total);
        }
    }
}