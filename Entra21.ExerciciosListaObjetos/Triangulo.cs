using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos
{
    public class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidarTriangulo()
        {
            if ((Lado1 + Lado2) > Lado3)
            {
                return true;
            }
            else if ((Lado2 + Lado3) > Lado1)
            {
                return true;
            }
            else if ((Lado3 + Lado1) > Lado2)
            {
                return true;
            }
            return false;

        }
    }
}
