using System;

namespace Recapitulacao
{
    class Program
    {
        static DadoAluno[] alunos;

        static void Main(string[] args)
        {
            Console.Write("Quantos alunos sua sala possui? ");
            int numeroAlunos = Int32.Parse(Console.ReadLine());
            alunos = new DadoAluno[numeroAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Print("Dados do aluno " + (i + 1));
                Console.Write("Qual o nome do seu aluno? ");
                string nome = Console.ReadLine();

                Console.Write("Qual a idade do seu aluno? ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Qual o curso do seu aluno? ");
                string curso = Console.ReadLine();

                Console.Write("Qual a nota do seu aluno? ");
                float nota = float.Parse(Console.ReadLine());
                Console.WriteLine();

                alunos[i] = new DadoAluno(nome, idade, curso, nota);
            }

            foreach (DadoAluno aluno in alunos)
            {
                Print(aluno.RetornaDadosDoAluno());
            }
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}