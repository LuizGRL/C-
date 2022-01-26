using System;
namespace ConsoleApplicationVsCode{
    class Ex3{
        static void Main(string[] args){
            // Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
            int[] idadePessoas;
            idadePessoas = new int[10];
            int contador = 0;
            for(int i = 0;i<idadePessoas.Length; i++){
                Console.WriteLine("Digite a idade da pessoa de número "+i+":");
                int idade =  Convert.ToInt32(Console.ReadLine());
                if(idade>18){
                    contador+=1;
                }
            }
            Console.WriteLine("Existem " +contador+" pessoas com idade superior à 18 anos.");
        }
    }
}