using Entra21.ExercicioCidades.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioCidades.Ado.Net.Service
{
    public interface ICidadeService
    {
        List<Cidades> ObterTodos();
    }
}
