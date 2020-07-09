using System;

class Aula08 {
    static void Main() {
        int Number1, Number2, Soma;

        Console.Write("Digite um primeiro valor: ");
        Number1 = int.Parse(Console.ReadLine());

        Console.Write("Digite um primeiro valor: ");
        Number2 = int.Parse(Console.ReadLine());

        Soma = Number1 + Number2;

        Console.WriteLine("A soma dos resultados é {0}", Soma);

    }
}