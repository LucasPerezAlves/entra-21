using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Entra21.ExemploWindowsForms.Exemplo01
{
    public partial class PacientesForms : Form
    {
        private PacienteServico pacienteServico;

        public PacientesForms()
        {
            InitializeComponent();



            //instanciar um objeto do PacienteServico, que é responsavel por gerenciar os dados dos pacientes
            pacienteServico = new PacienteServico();

            //Ler do arquivo Json os pacientes cadastrados anteriormente
            ListarPacientes();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            //Obter as informações dos campos 
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());


            //Verifica se o modo esta em adição
            if (dataGridView1.SelectedRows.Count == 0)
            {

                AdicionarPaciente(nome, peso, altura);

                return;
            }

            EditarDados(nome, peso, altura);


        }

        private void PacientesForm_Load(Object sender, EventArgs e)
        {
            Show();
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            //Obter a quantidade de linhas que o usuario selecionou no DataGridView 
            var quantidadeLinhaSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhaSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            //Verifica se o usuário escolheu realmente apagar o registo 
            if (opcaoEscolhida == DialogResult.Yes)
            {

                //Obtem o codigo do paciente escolhido para apagar 
                var linhaSelecionada = dataGridView1.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                //Apaga o paciente da lista de pacientes atualizando o arquivo Json
                pacienteServico.Apagar(codigoSelecionado);

                ListarPacientes();

            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            //Obter a linha que o usuário selecionou 
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            //Obter a informação da linha selecionada passado a coluna desejada 
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();
        }

        private void textBoxPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarPaciente(string nome, double peso, double altura)
        {
            var paciente = new Paciente()
            {
                Codigo = pacienteServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };

            //Adicionar informação na lista e atualizar o arquivo Json
            pacienteServico.Cadastrar(paciente);

            LimparCampos();

            ListarPacientes();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            //instanciar o paciente com os dados preenchidos na tela, para alterar o existente
            var paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Altura = altura;
            paciente.Peso = peso;

            //Obter o codigo do registro escolhido para alterar 
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            paciente.Codigo = codigo;

            //Alterar o paciente na lista de pacientes e atualizando o arquivo Json
            pacienteServico.Editar(paciente);

            LimparCampos();

            ListarPacientes();
        }

        private void LimparCampos()
        {
            textBoxPeso.Clear();
            textBoxNome.Clear();
            textBoxAltura.Clear();


            dataGridView1.ClearSelection();
        }

        private void ListarPacientes()
        {

            //Obter a lista dos pacientes para listar para o usuario
            var pacientes = pacienteServico.ObterTodos();

            //Remover todos os itens do DataGridView, pois será adicionado novamente
            dataGridView1.Rows.Clear();

            //Percorre a lista de pacientes
            for (int i = 0; i < pacientes.Count; i++)
            {
                //Obtem o paciente que esta sendo percorrido
                var paciente = pacientes[i];

                //Adicionar o paciente que estava no arquivo json no DataGridView
                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo , paciente.Nome, paciente.Altura, paciente.ObterImc()

                });
            }

            dataGridView1.ClearSelection();

        }

        private void PacientesForms_Load(object sender, EventArgs e)
        {
            ListarPacientes();
        }
    }
}
