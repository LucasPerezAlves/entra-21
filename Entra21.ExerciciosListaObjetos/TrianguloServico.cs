﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3, int codigo)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            triangulo.Codigo = codigoAtual;
            codigoAtual = codigoAtual + 1;

            triangulos.Add(triangulo);
            
            return true;
        }

        public bool Editar(int codigoParaAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar);
            if(trianguloParaAlterar == null)
            {
                return false;
            }

            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;

            return true;

        }
        public bool Apagar(int Codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                Triangulo triangulo = triangulos[i];
                if(triangulo.Codigo == Codigo)
                {
                    triangulos.Remove(triangulo);
                    return true;
                }
            }

            return false;
        }
        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }
        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if(trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }
            return null;
        }

    }
}
