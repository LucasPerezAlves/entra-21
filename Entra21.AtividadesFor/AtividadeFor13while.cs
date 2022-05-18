using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesFor {
    internal class AtividadeFor13while {
        public void Executar() {

            var nome = "";
            var idade = 0;
            var peso = 0.0;
            var sexo = "";
            var quantidadeGols = 0;
            var quantidadeAmarelos = 0;
            var quantidadeVermelhos = 0;
            var menorPeso = double.MaxValue;
            var maiorPeso = double.MinValue;
            var maiorAltura = double.MinValue;
            var altura = 0.0;
            var maiorNome = int.MinValue;
            var menorNome = int.MaxValue;
            var quantidadeLetrasNome = 0;
            var quantidadeJogadoresF = 0;
            var quantidadeJogadoresM = 0;
            var maisVermelhos = int.MinValue;
            var menosVermelhos = int.MaxValue;
            var maisAmarelos = int.MinValue;
            var menosAmarelos = int.MaxValue;
            var nome

            for (var i = 0; i < 22; i = i + 1) {

                quantidadeLetrasNome = nome.Length;
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();


                if (quantidadeLetrasNome < maiorNome) {

                    maiorNome = quantidadeLetrasNome;
                }
                
                if (quantidadeLetrasNome < menorNome) {
                    menorNome = quantidadeLetrasNome;
                }

                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Digite o seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                if (peso < menorPeso) {
                    menorPeso = peso;
                }

                if (peso < maiorPeso) {
                    maiorPeso = peso;
                }

                Console.WriteLine("Digite F/M: ");
                sexo = Console.ReadLine().Trim();

                if (sexo == "F") {
                    quantidadeJogadoresF = quantidadeJogadoresF + 1;
                }
                else if (sexo == "M") {
                    quantidadeJogadoresM = quantidadeJogadoresM + 1;
                }



                Console.Write("Digite a sua altura");
                altura = Convert.ToDouble(Console.ReadLine());

                if (maiorAltura < altura) {
                    maiorAltura = altura;
                }


                Console.WriteLine("Digite a quantidade de gols marcados: ");
                quantidadeGols = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Digite a quantidade de amarelos recebidos: ");
                quantidadeAmarelos = Convert.ToInt32(Console.ReadLine());
                
                if (menosAmarelos < quantidadeAmarelos) {
                    menosAmarelos = quantidadeAmarelos;
                }

                if (maisAmarelos < quantidadeAmarelos) {
                    maisAmarelos = quantidadeAmarelos;
                }

                Console.WriteLine("Digite a quantidade de vermelhos recebidos: ");
                quantidadeVermelhos = Convert.ToInt32(Console.ReadLine());

                if (maisVermelhos < quantidadeVermelhos) {
                    maisVermelhos = quantidadeVermelhos;
                }
                
                if (menosVermelhos < quantidadeVermelhos) {
                    menosVermelhos = quantidadeVermelhos;

                }

                Console.Clear();




            }
        }
    }
}
