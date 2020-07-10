using System;

namespace Program {

    class LI001 {

        static void Main() {
            int IdadeCidadão = 16;
            bool Écidadão = true;

            if ((IdadeCidadão >= 16) && (Écidadão == true)) {
                Console.WriteLine("Você pode votar!");
            } else if ((IdadeCidadão < 16) || (Écidadão != true)) {
                Console.WriteLine("Você NÃO pode votar!");
            }
        }

    }

}