using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemploWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;

        //construtor: construi o objeto que esta sendo instanciado com as devidas informações ou rotinas

        public EnderecosForm()
        {
            InitializeComponent();
            enderecoServico = new EnderecoServico();

            pacienteServico = new PacienteServico();

            PreencherComboBoxComOsNomesDosPacientes();

            PreencherDataGridViewComEnderecos();

            ObterDadosCep();
        }

        private void PreencherComboBoxComOsNomesDosPacientes()
        {
            //obter lista dos pacientes, que foram cadastradis, ou seja, aramazenados no json
            var pacientes = pacienteServico.ObterTodos();

            //percorre todos os pacientes adiocionado no combobox
            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCEP.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Obter os dados preenchidos pelo usuario armazenado em variaveis 
            var cep = maskedTextBoxCEP.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            //Construir o objeto do endereco com as variaveis 
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterNomePaciente(nomePaciente);

            //Salvar este endereco na lista de enderecos e no arquivo Json
            enderecoServico.Adicionar(endereco);

            //Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();
        }

        private void PreencherDataGridViewComEnderecos()
        {
            //Obter todos os endereços da lista de endereços
            var enderecos = enderecoServico.ObterTodos();

            //Remover a seleção do DataGridView
            dataGridView1.Rows.Clear();

            //Remover a seleção do DataGrdiView
            dataGridView1.ClearSelection();

            //Percorrer cada um dos endereços adicionado uma nova linha na tabela
            for (var i = 0; i < enderecos.Count; i++)
            {
                //Obter endereco percorrido
                var endereco = enderecos[i];

                //Cria uma nova linha no DataGridView com os dados referentes ao endereço

                dataGridView1.Rows.Add(new Object[]
                {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCEP.Text.Replace("-", "");
            
            var httpClient = new HttpClient();

            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text =
                    $"{dadosEndereco.Uf} - {dadosEndereco.Localidade} - {dadosEndereco.Bairro} - {dadosEndereco.Logradouro}";
            }
        }
    }
}
