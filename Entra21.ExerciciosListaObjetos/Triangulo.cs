using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos
{
    public class Triangulo
    {
        public int lado1;
        public int lado2;
        public int lado3;

        public bool ValidarTriangulo()
        {
            if ((lado1 + lado2) > lado3)
            {
                return true;
            }
            else if ((lado2 + lado3) > lado1)
            {
                return true;
            }
            else if ((lado3 + lado1) > lado2)
            {
                return true;
            }





        }
    }
}
