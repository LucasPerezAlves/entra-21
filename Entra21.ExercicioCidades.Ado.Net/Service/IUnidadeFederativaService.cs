using Entra21.ExercicioCidades.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioCidades.Ado.Net.Service
{
    internal interface IUnidadeFederativaService
    {
        void Cadastrar(UnidadesFederativas unidadesFederativas);
        List<UnidadesFederativas> ObterTodos();
        void Apagar(int id);
        UnidadesFederativas ObterPorId(int id);
        void Editar(UnidadesFederativas tipoPersonagem);
    }
}
