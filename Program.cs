using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {/*
            [console: MDC] Calcule o máximo divisor comum entre dois números utilizando o Algoritmo de Euclides (iterativo).
            Método: Dados os números a e b, efetue a divisão e pegue o resto. Se o resto for zero, a é o mdc. Senão, b é o novo a, e o resto é o novo b. Repita o processo até que o resto seja zero.
            Veja um exemplo de cálculo: https://pt.wikipedia.org/wiki/Algoritmo_de_Euclides#Exemplo
            Ex.:
            Máximo Divisor Comum (método iterativo)
            Digite o 1º número (a): 348
            Digite o 2º número (b): 156
            MDC(a, b) = 12

            [console: SomaDigitos] Calcule a soma dos dígitos de um número inteiro positivo informado.
            Ex.:
            Digite um número inteiro positivo: 5410587

            Dígitos: 7 8 5 0 1 4 5

            Soma = 30
            */

            int n1;
            int n2;
            int a;
            int b;
            int valor;

            bool positivo1;
            bool positivo2;

            // uso de variável booleana para admitir verdadeiro e falso
            // para isso utilizai como variáveis: positivo1 e positivo2 


            Console.Write("Digite o 1º número (a): ");

            positivo1 = Int32.TryParse (Console.ReadLine(), out n1);



            Console.Write("Digite o 2º número (b): ");

            positivo2 = Int32.TryParse (Console.ReadLine(), out n2);



            if (!positivo1 ||!positivo2 ||n1 <=0 || n2 <=0 )



            {

            Console.Write("Número inválido.");

            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");

            Console.ReadKey();

            Environment.Exit(-1);

            // comando para fechar o programa

            }



            if (n1 > n2)



            {

             a = n1;

             b = n2;

            }



            else



            {

             a = n2;

             b = n1;

            }



            while (a % b !=0)

            // conta para realizar o MDC



            {

             valor =a % b;

             a = b;

             b = valor;

            }

            Console.WriteLine($"MDC (a, b) = {b}");

            Console.WriteLine("Esse foi o meu programa, aperte qualquer tecla paa encerrar.");

            Console.ReadKey();
        }
    }
}
