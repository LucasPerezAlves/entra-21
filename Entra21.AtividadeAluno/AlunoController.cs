using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadeAluno
{
    internal class AlunoController
    {
        private AlunoServico alunoServico = new AlunoServico();

        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    CadastrarNovoAluno();
                }
                else if (codigo == 2)
                {
                    ExcluirAluno();
                }
                else if (codigo == 3)
                {
                    EditarDadosCadastrais();
                }
                else if (codigo == 4)
                {
                    AlterarNotaAlunos();
                }
                else if (codigo == 5)
                {
                    ListarNomes();
                }
                else if (codigo == 6)
                {
                    Listar
                }
                else if (codigo == 7)
                {
                    ObterPorCodigo();
                }
            }
        }

        private int ApresentarMenu()
        {

        }

        private int SolicitarCodigo()
        {

        }

        private void CadastrarNovoAluno()
        {

        }

        private void ExcluirAluno()
        {

        }

        private void EditarDadosCadastrais()
        {

        }

        private void AlterarNotaAlunos()
        {

        }

        private void ListarNomes()
        {

        }

        private void ListarAprovados()
        {

        }

        private void ListarReprovados()
        {

        }

        private void ListarEm_Exame()
        {

        }

        private void ApresentarMediaAlunoPorCodigo()
        {

        }

        private void ApresentarStatusAlunoPorCodigo()
        {

        }

        private void ApresentarMediaIdade()
        {

        }

        private void AlunosComNomeCodigo()
        {

        }
    }
}
