using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadeVetor1
    {
        public void Executar()
        {
            int[] numeros = new int[16];
            numeros[0] = 55;
            numeros[1] = 35;
            numeros[2] = 42;
            numeros[3] = 66;
            numeros[4] = 97;
            numeros[5] = 892;
            numeros[6] = 333;
            numeros[7] = 53;
            numeros[8] = 546;
            numeros[9] = 989;
            numeros[10] = 999;
            numeros[11] = 786;
            numeros[12] = 1212;
            numeros[13] = 5000;
            numeros[14] = 8787;
            numeros[15] = 1;

            Console.WriteLine("A soma desses números é de: " + (numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9] +
                numeros[10] + numeros[11] + numeros[12] + numeros[13] + numeros[14] + numeros[15]));
        }
    }
}
