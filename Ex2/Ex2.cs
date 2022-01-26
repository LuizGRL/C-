using System;
namespace ConsoleApplicationVsCode{
    class Ex2{
        static void Main(string[] args){
        // Crie um algoritmo que verifique se um número informado é par ou impar
            Console.WriteLine("Digite um número para verfificar se é par ou impar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if(numero%2==0){
                Console.WriteLine("O número digitado é par");
            }
            else{
                Console.WriteLine("O número digitado é impar");
            }
        }
    }
}