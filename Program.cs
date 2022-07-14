using System;

namespace Projeto_IMC2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Qual seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite dua idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o seu peso:");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora digite sua altura:");
            float altura = (float) Convert.ToDouble(Console.ReadLine());

            float resultado = peso / (altura * altura);

            if(resultado < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if(resultado >= 18 && resultado < 25)
            {
                Console.WriteLine("Você está no peso normal");
            }
            else if(resultado >= 25 && resultado < 30)
            {
                Console.WriteLine("Você está com excesso de peso");
            }
              else if(resultado >= 30)
            {
                Console.WriteLine("Você está obeso");
            }
        }
    }
}
