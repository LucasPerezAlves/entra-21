using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Entra21.ExemploWindowsForms.Exemplo01
{
    public partial class PacientesForms : Form
    {
       

        private List<Paciente> pacientes;

        private int codigo = 0;
        private int indiceLinhaSelecionada = -1;
        private int codigoSelecionado = -1;
        public PacientesForms()
        {
            InitializeComponent();

            //Cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

            //Ler do arquivo Json os pacientes cadastrados anteriormente
            LerArquivoApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            //Obter as informações dos campos 
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim());
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim());

            //Caluclar Imc
            var imc = CalcularImc(peso, altura);

            if (indiceLinhaSelecionada == -1)
            {
                //Adiciona linha no dataGridView do paciente 
                dataGridView1.Rows.Add(new object[]
                {
                    dataGridView1.Rows.Add(new Object[]{
                        ++codigo, nome, altura, peso, imc
                })
                    });

                AdicionarPacienteSalvandoNoArquivo(codigo, nome, peso, altura);

                return;
            }
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indiceLinhaSelecionada].Cells[4].Value = imc.ToString();

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
                var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

                //Remove a linha utilizando o indice no DataGridView
                dataGridView1.Rows.RemoveAt(quantidadeLinhaSelecionadas);

                //Remove o paciente da lista de pacientes
                pacientes.RemoveAt(quantidadeLinhaSelecionadas);

                //Atualiza o arquivo com a lista de pacientes sem o paciente removido
                SalvarEmArquivo();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
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

        private void textBoxPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarPacienteSalvandoNoArquivo(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente()
            {
                Codigo = codigo,
                Nome = nome,
                Altura = altura,
                Peso = peso
            };


            pacientes.Add(paciente);

            SalvarEmArquivo();
            LimparCampos();
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indiceLinhaSelecionada].Nome = nome;
            pacientes[indiceLinhaSelecionada].Peso = peso;
            pacientes[indiceLinhaSelecionada].Altura = altura;

            SalvarEmArquivo();
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxPeso.Text = "";
            textBoxNome.Text = "";
            textBoxAltura.Text = "";

            indiceLinhaSelecionada = -1;

            dataGridView1.ClearSelection();
        }

        private void SalvarEmArquivo()
        {
            //Converter uma lista de objetos em uma string contendo Json
            var pacientesJson = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.Json";

            //Salva a string contento Json em um arquivo no formato Json
            File.WriteAllText(caminho, pacientesJson);
        }

        private void LerArquivoApresentandoPacientes()
        {
            //Validar se arquivo não existe, consequentemente não é necessário percorrer uma lista que não existe
            if (File.Exists("pacientes.json") == false)
                return;

            //Ler arquivo Json e aramazenar os pacientes na lista de pacientes
            var conteudoArquivo = File.ReadAllText("pacientes.Json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivo);

            //Cria uma váriavel para armazenar o código de ultimo produto, para quando cadastrar um novo armazenar com o código correto
            var maiorCodigo = int.MinValue;

            //Percorre a lista de pacientes
            for (int i = 0; i < pacientes.Count; i++)
            {
                //Obtem o paciente que esta sendo percorrido
                var paciente = pacientes[i];

                //Adicionar o paciente que estava no arquivo json no DataGridView
                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo , paciente.Nome, paciente.Altura, CalcularImc(paciente.Peso , paciente.Altura)

                });
                //Rotina para descobrir o paciente com o maior codigo
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;
            }
            //Validar se conseguiu encontrar algum codigo, caso contrario n deve atualizar o codigo do novo paciente
            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;


        }
        private double CalcularImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }
    }
}
