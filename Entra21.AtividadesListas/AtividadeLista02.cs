using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesListas
{
    internal class AtividadeLista02
    {
        public void Executar()
        {
            List <string> bolo = new List<string>();
            bolo.Add("Como fazer um bolo");
            Console.WriteLine("[0]" + bolo);

            bolo[0] = "Algoritmos onde vivem? Do que se alimentam";
            bolo.Add("Variáveis");
            bolo.Add("Mais pra frente");

            bolo[2] = "if com E";
            bolo.Add("if com ou");
            bolo.Add("While");
            bolo.Add("For");

            Console.WriteLine("[0]" + bolo[0] +
                "\n[1]" + bolo[1] +
                "\n[2]" + bolo[2] +
                "\n[3]" + bolo[3] +
                "\n[4]" + bolo[4] +
                "\n[5]" + bolo[5]);

            bolo.Add("Vetor");
            bolo.Add("Vetor");
            bolo.RemoveAt(6);
            bolo.RemoveAt(7);
            bolo.Add("Vetor");
            bolo[6] = ("Vetor com For um amor na minha vida");

            Console.WriteLine("[0]" + bolo[0] +
                "\n[1]" + bolo[1] +
                "\n[2]" + bolo[2] +
                "\n[3]" + bolo[3] +
                "\n[4]" + bolo[4] +
                "\n[5]" + bolo[5] +
                "\n[6]" + bolo[6]);

            bolo.Add("Classe propriedades e métodos");

            Console.WriteLine("[0]" + bolo[0] +
                "\n[1]" + bolo[1] +
                "\n[2]" + bolo[2] +
                "\n[3]" + bolo[3] +
                "\n[4]" + bolo[4] +
                "\n[5]" + bolo[5] +
                "\n[6]" + bolo[6] +
                "\n[7]" + bolo[7]);
        }
    }
}
