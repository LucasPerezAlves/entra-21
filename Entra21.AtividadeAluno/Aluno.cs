using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadeAluno
{
    internal class Aluno
    {
        public string Nome;
        public int Idade;
        public string MateriaFavorita;
        public int CodigoMatricula;
        public double Nota01;
        public double Nota02;
        public double Nota03;
        

        public double CalcularMedia()
        {
            var media = (Nota01 + Nota02 + Nota03) / 3;
            return media;
        }
        
        public AlunoStatus ObterStatus()
        {
            AlunoStatus alunoStatus = new AlunoStatus();
            
            if (CalcularMedia() >= 7)
            {
                alunoStatus = AlunoStatus.Aprovado;
            }
            else if (CalcularMedia() < 6)
            {
                alunoStatus = AlunoStatus.Em_Exame;
            }
            else
            {
                return AlunoStatus.Reprovado;
            }

            return alunoStatus;
        }
    }
}
