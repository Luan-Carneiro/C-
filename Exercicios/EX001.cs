using System;

class Exercicio {
    static void Main() {

        double Age1, Age2, Age3, Age4, Age5, Average;

        Console.Write("Digite a idade do primeiro Aluno: ");
        Age1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a idade do segundo Aluno: ");
        Age2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a idade do terceiro Aluno: ");
        Age3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a idade do quarto Aluno: ");
        Age4 = double.Parse(Console.ReadLine());

        Console.Write("Digite a idade do quinto Aluno: ");
        Age5 = double.Parse(Console.ReadLine());

        Average = (Age1 + Age2 + Age3 + Age4 + Age5) / 5;

        Console.WriteLine("A media de idade dos alunos é {0}!", Average);

    }
}