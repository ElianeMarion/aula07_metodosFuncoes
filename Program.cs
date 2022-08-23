using System;

namespace Aula07_MetodosFuncoes
{
    class Program
    {
        /*Elabore um programa com uma função que solicita a digitação de dois números, sendo o primeiro a base e o segundo o expoente. Faça o cálculo e exiba o resultado*/

        /* public static void calcular(double b, double e) //b=2; e=3
         {
             double resultado = 1;
             for (int i = 1; i <= e; i++)
                 resultado *= b; //resultado = resultado * b;
             Console.WriteLine("Resultado = {0}", resultado.ToString());
         }
         static void Main(string[] args)
         {
             double numeroBase, numeroExpoente;
             Console.WriteLine("Digite um número para representar a base: ");
             numeroBase = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Digite um número para representar o expoente: ");
             numeroExpoente = Convert.ToDouble(Console.ReadLine());
             calcular(numeroBase, numeroExpoente); //calcular(2,3)
         }

         /*Elabore um programa com uma função que solicita a digitação de uma temperatura em graus Celsius e exiba a temperatura convertida em graus Fahrenheit,
          * utilizando a fórmula (onde C é a temperatura em Celsius)
         */

        //Primeira solução
       /* public static double TC;

        public static void conversaoTemperatura()
        {
            double TF = TC * 1.8 + 32;
            Console.WriteLine("{0}°C convertido em °F = {1}", TC.ToString(), TF.ToString());
        }

        public static void lerTemperatura()
        {
            Console.WriteLine("Digite a temperatura em °C: ");
            TC = Convert.ToDouble(Console.ReadLine());
            
        }

        static void Main(string[] args)
        {
            lerTemperatura();
            conversaoTemperatura();

        }*/
        //Solução 2 passando como parâmetro a TC
        public static void conversaoTemperatura(double c)
        {
            double TF = c * 1.8 + 32;
            Console.WriteLine("{0}°C convertido em °F = {1}", c.ToString(), TF.ToString());
        }

        public static void lerTemperatura()
        {
            Console.WriteLine("Digite a temperatura em °C: ");
            double TC = Convert.ToDouble(Console.ReadLine());
            conversaoTemperatura(TC);
        }

        static void Main(string[] args)
        {
            lerTemperatura();
            
        }
        
        //Terceira solução
        /*
        public static void conversaoTemperatura(double c) // c =15
        {
            double TF = c * 1.8 + 32;
            Console.WriteLine("{0}°C convertido em °F = {1}", c.ToString(), TF.ToString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em °C: ");
            double TC = Convert.ToDouble(Console.ReadLine());
            conversaoTemperatura(TC);

        }

        /*
        //public static double res;
        public static int opcao;
        public static double n1, n2;
        //funções
        public static void exibirMenu()
        {
            Console.WriteLine("Agora, selecione a operação:\n\n" +
                "1 - Adição\n" +
                "2 - Subtração\n" +
                "3 - Multiplicação\n" +
                "4 - Divisão\n");
            opcao = Convert.ToInt32(Console.ReadLine());
        }

        public static void entradaDeDados()
        {
            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
        }

        public static void exibirResultado(double resultado)
        {
            Console.WriteLine("O resultado foi: {0}", resultado.ToString());
        }

        public static void somarNumeros(double num1, double num2)
        {
            double soma = num1 + num2;
            Console.WriteLine("A soma é {0}", soma.ToString());
        }
        static void Main(string[] args)
        {
            double res = 0;
            Console.WriteLine("Minha Super Calculadora\n\n");
            entradaDeDados();           
            exibirMenu();    
            switch (opcao)
            {
                case 1:
                    somarNumeros(n1, n2); //somarNumeros(10,5)
                    res = n1 + n2;
                    //Console.WriteLine("Soma {0}", res.ToString());
                    break;
                case 2:
                    res = n1 - n2;
                    //Console.WriteLine("Subtração {0}", res.ToString());
                    break;
                case 3:
                    res = n1 * n2;
                   // Console.WriteLine("Multiplicação {0}", res.ToString());
                    break;
                case 4:
                    if (n2 != 0)
                    {
                        res = n1 / n2;
                     //   Console.WriteLine("Divisão {0}", res.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Impossível dividir por zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            exibirResultado(res);


        }
        */
        //funções

    }
}
