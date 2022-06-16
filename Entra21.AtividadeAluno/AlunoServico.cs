using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadeAluno
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();
        private int CodigoMatricula = 1;

        public void Adicionar(string nome, int idade, int Nota01, int Nota02, int Nota03, string materiaFavorita, int codigoMatricula)
        {
            var aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Nota01 = Nota01;
            aluno.Nota02 = Nota02;
            aluno.Nota03 = Nota03;
            aluno.CodigoMatricula = codigoMatricula;

            codigoMatricula = codigoMatricula + 1;
            alunos.Add(aluno);  
        }

        public bool Remover(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno aluno = alunos[i];
                if (aluno.Nome == nome)
                {
                    alunos.Remove(aluno);
                    return true;
                }

            }
            return false;
        }

        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materiaFavorita)
        {
            Aluno alunoParaAlterar = ObterPorCodigo(codigoMatricula);

            if (alunoParaAlterar == null) 
            {
                return false;
            }

            alunoParaAlterar.Nome = nome;
            alunoParaAlterar.Idade = idade;
            alunoParaAlterar.MateriaFavorita = materiaFavorita;

            return true;
        }

        public bool EditarNotasAluno(int codigoMatricula, double nota01, double nota02, double nota03)
        {
            Aluno notaParaAlterar = ObterPorCodigo(codigoMatricula);

            if(notaParaAlterar == null)
            {
                return false;
            }

            notaParaAlterar.Nota01 = nota01;
            notaParaAlterar.Nota02 = nota02;
            notaParaAlterar.Nota03 = nota03;

            return true;
        }

        public List<string> ObterNomes()
        {
            var nomes = new List<string>();
            for (int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

            }
            return nomes;
        }

        public List<Double> ObterMedias()
        {
            var medias = new List<Double>();
            for (int i = 0;i < alunos.Count; i++)
            {
                var media = alunos[i].CalcularMedia();
                medias.Add(media);
            }
            return medias;
        }

        public List<string> ObterAprovados()
        {
            var aprovados = new List<string>();
            for (var i = 0; i <= alunos.Count; i++)
            {
                var aprovado = alunos[i].ObterStatus();
            }
            return aprovados;
        }

        public List <string> ObterReprovados()
        {
            var reprovados = new List<string>();
            for (var i = 0; i <= alunos.Count; i++)
            {
                var reprovado = alunos[i].ObterStatus();
            }
            return reprovados;
        }
    

        public List<string> Obter_EmExame()
        {
            var Em_Exame = new List<string>();
            for (var i = 0; i <= alunos.Count; i++)
            {
                var Em_Exames = alunos[i].ObterStatus();
            }
            return Em_Exame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            for(var i = 0;i <= alunos.Count; i++)
            {
                var aluno = alunos[i];

                if(aluno.CodigoMatricula == codigoMatricula)
                {
                    return aluno.CalcularMedia();
                }

            }
            return 
        }

        public AlunoStatus ObterStatusPorCodigoMatricula(int codigo)
        {

        }

        public double ObterMedialdes()
        {

        }

        public Aluno ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                var codigoAtual = alunos[i];

                if(codigoAtual.CodigoMatricula == codigo)
                {
                    return codigoAtual;
                }
            }
            return null;
        }
    }
}
