using Entra21.ExercicioCidades.Ado.Net.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExercicioCidades.Ado.Net.Views
{
    public partial class CidadesForm : Form
    {
        public CidadesForm()
        {
            InitializeComponent();
        }

        private void PreencherComboBoxUnidadeFederativa()
        {
            var unidadeFederativaService = new UnidadeFederativaService();
            var unidadeFederativa = unidadeFederativaService.ObterTodos();

            for(int i = 0; i < unidadeFederativa.Count; i++)
            {
                var unidadesFederativas = unidadeFederativa[i];
                comboBoxUnidadeFederativa.Items.Add(unidadesFederativas);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecione uma cidade!!");
            return;

            var nome = textBoxNome.Text.Trim();
            var quantidadeHabitantes = maskedTextBoxQuantidadeHabitantes;
            var pib = maskedTextBoxPib;

            var cidade = new Cidades();
            cidade.Nome = nome;
            cidade.QuantidadeHabitantes = quantidadeHabitantes;
            cidade.Pib = pib;

            var unidadeFederativa = new Unidades_Federativas();
            if(_idParaEditar == -1)
            {
                unidadeFederativa.Cadastrar(cidade);

                MessageBox.Show("cidade cadastrada com sucesso!!");
                Close();
            }
            else
            {
                cidade.Id = _idP
            }
        }
    }
}
