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
            LimparCampos();

        }

        private void LimparCampos()
        {
            maskedTextBoxCEP.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;

            dataGridView1.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Obter os dados preenchidos pelo usuario armazenado em variaveis 
            var cep = maskedTextBoxCEP.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            //Executa o método ValidarDados que retornará um bool sendo true quando os dados forem validos 
            //False quando for invalidos
            var validarDados = ValidarDados(cep, enderecoCompleto, nomePaciente);

            //Verifica se os dados são validos para não dar continuidade no cadastro do endereço
            if (validarDados == false)
                return;

            //Verificar se nao esta em edição, ou seja, modo de cadastro
            if (dataGridView1.SelectedRows.Count == 0)
                CadastrarEndereco(cep, enderecoCompleto, nomePaciente);
            else
                EditarEndereco(cep, enderecoCompleto, nomePaciente);

            CadastrarEndereco(cep, enderecoCompleto, nomePaciente);

            //Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();

            LimparCampos();
        }

        private void EditarEndereco(string cep, string enderecoCompleto, string nomePaciente)
        {
            //Obter linha selecionada
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            //Obter codigo que esta na coluna oculta no dataGridView
            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            //Construir o objeto com os dados da tela
            var endereco = new Endereco();
            endereco.Codigo = codigoSelecionado;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Cep = cep;
            endereco.Paciente = pacienteServico.ObterNomePaciente(nomePaciente);

            //Atualizar o dado na lista de enderecos e salvar o dado atualizado no arquivo JSON
            enderecoServico.Editar(endereco);
        }
        private void CadastrarEndereco(string cep, string enderecoCompleto, string nomePaciente)
        {
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            endereco.Paciente = pacienteServico.ObterNomePaciente(nomePaciente);

            //Salvar este endereco na lista de enderecos e no arquivo Json
            enderecoServico.Adicionar(endereco);
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
            ApresentarDadosParaEdicao();
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para editar");

                return;
            }
            //Obter a linha que o usuario escolheu
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            //Obter o codigo do endereço que o usuario selecionou
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            //Obter o endereço escolhido
            var endereco = enderecoServico.ObterPorCodigo(codigo);

            //Apresentar os dados do endereço na sua tela para edição
            maskedTextBoxCEP.Text = endereco.Cep;
            textBoxEnderecoCompleto.Text = endereco.EnderecoCompleto;
            comboBoxPaciente.SelectedItem = endereco.Paciente.Nome;
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCEP.Text.Replace("-", "").Trim();

            //89070200
            if (cep.Length != 8)
            {
                return;
            }

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

        //Sera executado este metodo quando o usuario sair do campo cep
        private void maskedTextBoxCEP_Leave(object sender, EventArgs e)
        {
            ObterDadosCep();
        }

        private bool ValidarDados(string cep, string enderecoCompleto, string nomePaciente)
        {
            if (cep.Replace("-", "").Trim().Length != 8)
            {

                MessageBox.Show("CEP inválido");

                maskedTextBoxCEP.Focus();

                return false;
            }

            if (enderecoCompleto.Trim().Length < 10)
            {
                MessageBox.Show("Endereço completo deve conter no mínimo 10 caracteres");

                maskedTextBoxCEP.Focus();

                return false;
            }

            if (comboBoxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um paciente");

                comboBoxPaciente.DroppedDown = true;

                return false;
            }
            return true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //Verificar se algum item no DataGridView está selecionado
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um endereço para remover");

                return;
            }
            //Questionar se o usuario deseja apagar
            var resposta = MessageBox.Show("Deseja realmente apagar o endereço", "Aviso",
                MessageBoxButtons.YesNo);

            //Validar que o usuario não escolheu sim, pq n devera continuar executando 
            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Relaxa teu registro ta ai salvo");

                return;
            }

            //Qual item sera apagado
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            //Obter o código da linha selecionada na primeira coluna, que nao esta sendo apresentada para o usuario
            //que é referente ao codigo do endereco
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);


            //✔ Apagar o item da lista de itens no serviço
            //✔ Atualizar o arquivo Json

            //Buscar o endereco da lista de enderecos filtrando por codigo 
            var endereco = enderecoServico.ObterPorCodigo(codigo);
            //Apagar o endereco encontrado da lista de enderecos e atualizar o arquivo Json
            enderecoServico.Apagar(endereco);


            //Atualizar o DataGridView
            PreencherDataGridViewComEnderecos();

            //Remover a seleção do DataGridView
            dataGridView1.ClearSelection();
        }

        //Quando o formulário é carregado apresenta os dados no DataGridView
        private void EnderecosForm_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewComEnderecos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApresentarDadosParaEdicao();
        }
    }

}