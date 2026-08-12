using System;

//comentario teste commit Aula 03
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ConcatenarPalavras();
            //CalcularMedia();
            //CalcularTabuada();
            VerificarAulaEtec();
        }

        public static void CalcularMedia()
        {
             Console.WriteLine("digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A media é {media}");

            if(media >= 7)
            Console.WriteLine("aprovado");
            else if(media < 7 && media >= 4 )
            Console.WriteLine("Recuperação");
            else
            Console.WriteLine("Reprovado");
        }
        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine($"Seu nome tem {nome.Length} caracteres.");

            Console.WriteLine("Digite a data de nascimento: ");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());
            int qtdDiasVividos = DateTime.Now.Subtract(dtNascimento).Days;
            Console.WriteLine("Os dias vividos até hoje são: " + qtdDiasVividos);

            Console.ReadKey();
        }

            public static void CalcularTabuada()
            {
                System.Console.WriteLine("digite a tabuada que deseja calcular");
                int tabuada = int.Parse(Console.ReadLine());
                int contador = 0;

                while (contador <= 10)
                {
                    string mensagem = string.Format("{0} X {1} = {2}", tabuada, contador, tabuada * contador);
                    Console.WriteLine(mensagem);
                    contador++;
                }
            } 
            
            public static void VerificarAulaEtec()
        {
          Console.WriteLine("digite a data");
          DateTime data = DateTime.Parse(Console.ReadLine());
          if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje nao tem aula! revisarei exercicios.");
            }
            else
            {
                Console.WriteLine("Dia da semana! Bora pra etec!");
            }
        }         

        

    }
}


