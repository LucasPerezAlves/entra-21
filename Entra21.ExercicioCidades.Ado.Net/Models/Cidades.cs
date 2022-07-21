using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioCidades.Ado.Net.Models
{
    public class Cidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade_Habitantes { get; set; }
        public DateTime Data_Hora_Fundacao { get; set; }
        public decimal Pib { get; set; }
        //Será preenchido com innerJoin
        public Cidades UnidadeFederativa { get; set; }
    }
}
