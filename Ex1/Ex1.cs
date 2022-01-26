using System;

namespace ConsoleApplicationVSCode{
    class Ex1{
        static void Main(string[] args){
            // 1 – Elabore um algoritmo que calcule a idade média de 5 alunos.
            int[] idade;
            idade = new int[5];
            int mediaIdades=0;
            for (int i=0;i < idade.Length;i++){
                Console.WriteLine("Digite a idade do aluno de número " +i+": ");
                int idadeAluno = Convert.ToInt32(Console.ReadLine());
                mediaIdades += idadeAluno;
            }

            Console.Write("A média de idade dos alunos da turma é igual a: "+ mediaIdades/idade.Length);


        }
    }
    
}

