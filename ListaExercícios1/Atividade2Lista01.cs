using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadeLista1
{
    internal class Atividade2Lista01
    {
        public void Executar()
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = nome + sobrenome;

            Console.Write("Seu nome completo é: " + nomeCompleto);
        }
    }
}
