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
            int qtdalunos;

            Console.Write("Quantas turmas? ");
            turma = Convert.ToInt32(Console.ReadLine());

            int[] Listaturma = new int[turma];

            for (int i = 0; i < turma; i++)
            {
                Console.Write("Quantos alunos tem na turma" + i + ": ");
                turma = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
