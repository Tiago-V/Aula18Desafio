using System;

namespace Exercicio
{
    public class Jogador
    {
        //var atributos: Nome, Posição, Data de Nascimento, Nacionalidade, Altura e Peso.
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public string MostrarDados(){
            
            return $"Nome: {Nome} \nPosição: {Posicao} \nData de Nascimento: {DataNascimento} \nNacionalidade: {Nacionalidade} \nAltura: {Altura}cm \nPeso: {Peso}kg";

        }
        public int idade { get; set; }
        public int CalcIdade(){
            //Array
            //0     1     2
            //05 / 02 / 1985

            int anoNasci = Int32.Parse(DataNascimento.ToString().Split('/', ' ')[2]);
            int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/', ' ')[2]);

            idade = anoAtual - anoNasci;

            return idade;

        }
        public string Aposentadoria(){
            //Atacante 35 anos
            //Meio-campo 38 anos
            //Defesa 40 anos
            
            
            string aposentadoria = "";

            if(Posicao == "Atacante" && idade < 35){

                idade = 35 - CalcIdade();
                aposentadoria = $"O jogador atacante só pode se aposentar com 35 anos. Falta {idade} anos pro jogador se aposentar.";

            }else if(Posicao == "Meio-Campo" && idade < 38){

                idade = 38 - CalcIdade();
                aposentadoria = $"O jogador meio-campo só pode se aposentar com 38 anos. Falta {idade} anos pro jogador se aposentar.";

            }else if(Posicao == "Defesa" && idade < 40){

                idade = 40 - CalcIdade();
                aposentadoria = $"O jogador defesa só pode se aposentar com 40 anos. Falta {idade} anos pro jogador se aposentar.";

            }else{

                aposentadoria = "O jogador pode se aposentar.";

            }

            return aposentadoria;

        }
        



    }
}