using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile2
    {
        public void Executar()
        {
            //2 Solicite nomes ao usuário até que o mesmo digite fim para o nome

            int quantidade = 0;
            string nome = "";

            while (nome != "fim")
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine();
                quantidade = quantidade + 1;

            }
        }
    }
}
