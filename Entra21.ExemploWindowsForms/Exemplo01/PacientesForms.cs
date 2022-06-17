using System;
using System.Windows.Forms;

namespace Entra21.ExemploWindowsForms.Exemplo01
{
    public partial class PacientesForms : Form
    {
        private int codigo = 1;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForms()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            
            //Obter as informações dos campos 
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            //Caluclar Imc
            var imc = peso / (altura * altura);

            if (indiceLinhaSelecionada == -1)
            {
                //Adiciona linha no dataGridView do paciente 
                dataGridView1.Rows.Add(new object[]
                {
                    codigo++, nome, altura, peso, imc
                });
                return;
            }
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();
        }
        private void PacientesForm_Load(Object sender, EventArgs e)
        {
            Show();
        }
        private void Apagar_Click(object sender, EventArgs e)
        {
            //Pegar o indice da linha selecionada 
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if(indiceLinhaSelecionada == 1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            //Verifica se o usuário escolheu realmente apagar o registo 
            if(opcaoEscolhida == DialogResult.Yes)
            {
                //Remove a linha utilizando o indice no DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if(indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            //Obter a linha que o usuário selecionou 
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            //Obter a informação da linha selecionada passado a coluna desejada 
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

    }
}
