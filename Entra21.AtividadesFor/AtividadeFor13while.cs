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
            var nomeMaisVermelhos = "";
            var nomeMenosVermelhos = "";
            var nomeMaisAmarelos = "";
            var nomeMenosAmarelos = "";

            for (var i = 0; i < 2; i = i + 1) {

                var nomeValido = false;
                while (nomeValido == false) {
                    try {
                        Console.WriteLine("Digite o seu nome: ");
                        nome = Console.ReadLine();
                        quantidadeLetrasNome = nome.Length;
                        nomeValido = true;
                    }

                    catch (Exception ex) {
                        Console.WriteLine("Nome inválido!!");
                    }

                }


                if (quantidadeLetrasNome > maiorNome) {

                    maiorNome = quantidadeLetrasNome;
                }

                if (quantidadeLetrasNome < menorNome) {
                    menorNome = quantidadeLetrasNome;
                }
                var idadeValida = false;
                while (idadeValida == false) {
                    try {
                        Console.WriteLine("Digite a sua idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        idadeValida = true;
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Idade inválida!!");
                    }
                }

                var pesoValido = false;
                while (pesoValido == false) {
                    try {
                        Console.WriteLine("Digite o seu peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        pesoValido = true;

                        if (peso < menorPeso) {
                            menorPeso = peso;
                        }

                        if (peso > maiorPeso) {
                            maiorPeso = peso;
                        }
                    }

                    catch (Exception ex) {
                        Console.WriteLine("Peso digitado é inválido!!");
                    }
                }

                var sexoValido = false;
                while (sexoValido == false) {
                    try {
                        Console.WriteLine("Digite F/M: ");
                        sexo = Console.ReadLine().ToLower().Trim();
                        sexoValido = true;

                        if (sexo == "f") {
                            quantidadeJogadoresF = quantidadeJogadoresF + 1;
                        }
                        else if (sexo == "m") {
                            quantidadeJogadoresM = quantidadeJogadoresM + 1;
                        }
                    }

                    catch (FormatException ex) {
                        Console.WriteLine("Sexo inválido!!");
                    }
                }
                    var alturaValida = false;
                while (alturaValida == false) {
                    try {
                        Console.WriteLine("Digite a sua altura");
                        altura = Convert.ToDouble(Console.ReadLine());
                        alturaValida = true;

                        if (altura > maiorAltura) {
                            maiorAltura = altura;
                        }
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Altura digitada é inváida!!");
                    }
                }


                var golsValidos = false;
                while (golsValidos == false) {
                    try {

                        Console.WriteLine("Digite a quantidade de gols marcados: ");
                        quantidadeGols = Convert.ToInt32(Console.ReadLine());
                        golsValidos = true;
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Gols digitado é inválido!!");
                    }
                }
                var amareloValido = false;
                while (amareloValido == false) {
                    try {

                        Console.WriteLine("Digite a quantidade de amarelos recebidos: ");
                        quantidadeAmarelos = Convert.ToInt32(Console.ReadLine());
                       

                        if (quantidadeAmarelos < menosAmarelos) {
                            menosAmarelos = quantidadeAmarelos;
                        }

                        if (quantidadeAmarelos > maisAmarelos) {
                            maisAmarelos = quantidadeAmarelos;
                        }

                        nomeMaisAmarelos = nome;
                        nomeMenosAmarelos = nome;
                        amareloValido = true;
                    }
                   


                    catch (Exception ex) {
                        Console.WriteLine("Quantidade amarelos digitado é inválido!!");
                    }
                }

                var vermelhoValido = false;
                while (vermelhoValido == false) {
                    try {
                        Console.WriteLine("Digite a quantidade de vermelhos recebidos: ");
                        quantidadeVermelhos = Convert.ToInt32(Console.ReadLine());
                       

                        if (quantidadeVermelhos > maisVermelhos) {
                            maisVermelhos = quantidadeVermelhos;
                        nomeMaisVermelhos = nome;
                        }

                        if (quantidadeVermelhos < menosVermelhos) {
                            menosVermelhos = quantidadeVermelhos;

                        nomeMenosVermelhos = nome;
                        }
                        vermelhoValido = true;
                    }


                    catch (Exception ex) {
                        Console.WriteLine("Quantidade de vermelhos digitado é inválido!!");
                    }
                }


                        Console.Clear();




                    }
                        Console.WriteLine("O jogador com menor peso é: "+ menorPeso +
                            "\nO jogador com maior peso é: " + maiorPeso +
                            "\nO jogador com maior altura é: " + maiorAltura +
                            "\nO jogador com maior nome é: " + maiorNome +
                            "\nO jogador com menor nome é: " + menorNome +
                            "\nA quantidade de jogadoras do sexo feminino é: " + quantidadeJogadoresF +
                            "\nA quantidade de jogadores do sexo masculino é: " + quantidadeJogadoresM +
                            "\nO jogador com maior quantidade de vermelhos recebido é: " + nomeMaisVermelhos + "/" + maisVermelhos +
                            "\nO jogador com menor quantidade de vermehos recebido é: " + nomeMenosVermelhos + "/" + menosVermelhos +
                            "\nO jogador com maior quantidade de amarelos recebido é: " + nomeMaisAmarelos + "/" + maisAmarelos +
                            "\nO jogador com menor quantidade de amrelos recebido é: " + nomeMenosAmarelos + "/" + menosAmarelos);
        }
    }
}
