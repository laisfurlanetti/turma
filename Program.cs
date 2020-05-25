using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turma
{
    class Program
    {
        static void Main(string[] args)
        {
            int turma;

            Console.Write("Quantas turmas? ");
            turma = Convert.ToInt32(Console.ReadLine());

            int[] listaaluno = ObterListaAluno(turma);

            var media = listaaluno.Average();
            Console.Write("A media e: " + media);
            Console.Read();
        }
        public static int[] ObterListaAluno(int turma)
        {
            int[] listaaluno = new int[turma];

            for (int i = 0; i < turma; i++)
            {
                Console.Write("Quantos alunos tem na turma " + (i + 1) + ": ");
                var qtdalunos = Convert.ToInt32(Console.ReadLine());

                if (qtdalunos <= 40)
                {
                    listaaluno[i] = qtdalunos;
                }
                else
                {
                    while (qtdalunos > 40)
                    {
                        Console.Write("Quantidade de aluno maior que o informado, digite novamente: ");
                        qtdalunos = Convert.ToInt32(Console.ReadLine());
                    }
                    listaaluno[i] = qtdalunos;
                }
            }
            return listaaluno;
        }
    }
}
