using System;
namespace ConsoleApplicationVsCode{
    class Ex4{
        static void Main(string[] args){
            // 4 – Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a 
            // seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.
            double[] salarioFuncionario;
            salarioFuncionario = new double[10];

            for(int i = 0; i< salarioFuncionario.Length ;i++){
                Console.WriteLine("Informe o salário do funcionário de número " +i+": ");
                salarioFuncionario[i] = Convert.ToDouble(Console.ReadLine());
                if(salarioFuncionario[i] <=300.00){
                    salarioFuncionario[i]+= (salarioFuncionario[i]*0.5);
                    Console.WriteLine("O salario Reajustado do funcionário de número "+i+" é igual a "+salarioFuncionario[i] + "R$");
                }
                else if(salarioFuncionario[i]>=300.00){
                    salarioFuncionario[i]+= (salarioFuncionario[i]*0.3);
                    Console.WriteLine("O salario Reajustado do funcionário de número "+i+" é igual a "+salarioFuncionario[i] + "R$");
                }
                
            }


        }
    }
}