using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class ExemploProfessor
    {
        public void Executar()
        {
            
            
                var table = new ConsoleTable("caça", "padaria", "joão");
                table.AddRow(1, 2, 3)
                     .AddRow(8002, "cachaça " , "80");
                table.Write();
                

            
        }
    }
}
