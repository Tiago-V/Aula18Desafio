using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador cr7 = new Jogador();

            cr7.Nome = "Cristiano Ronaldo";
            cr7.Posicao = "Atacante";
            cr7.DataNascimento = DateTime.Parse("05/02/1985");
            cr7.Nacionalidade = "Português";
            cr7.Altura = 189;
            cr7.Peso = 85;

            cr7.MostrarDados();

            Console.WriteLine(cr7.MostrarDados());

            Console.WriteLine();


            Console.WriteLine("Aposentadoria:");
            Console.WriteLine("A idade do jogador é "+cr7.CalcIdade());
            Console.WriteLine(cr7.Aposentadoria());
        }
    }
}
