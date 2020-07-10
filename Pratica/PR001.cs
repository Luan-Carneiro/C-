using System;

class Program {
    static void Main() {
        Console.Clear();

        Console.WriteLine("Selecione uma das opções abaixo!");
        Console.WriteLine("1 - Tela 1");
        Console.WriteLine("2 - Tela 2");
        Console.WriteLine("3 - Tela 3");

        Console.WriteLine();

        int userChoice;

        Console.Write("Opção: ");
        userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1) {
            Teste1();
        } else if (userChoice == 2) {
            Teste2();
        } else if (userChoice == 3) {
            Teste3();
        } else {
            Console.WriteLine("Opção Invalido!");
        }
    }

    static void Teste1() {
        Console.WriteLine("Tela 1!!");
    }

    static void Teste2() {
        Console.WriteLine("Tela 2!!");
    }

    static void Teste3() {
        Console.WriteLine("Tela 3!!");
    }
}