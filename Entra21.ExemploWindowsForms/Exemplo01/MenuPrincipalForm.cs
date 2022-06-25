using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemploWindowsForms.Exemplo01
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            var pacientesForm = new PacientesForms();
            pacientesForm.ShowDialog();
        }

        private void buttonEnderecos_Click(object sender, EventArgs e)
        {
            var enderecosForm = new EnderecosForm();
            enderecosForm.ShowDialog();
        }
    }
}
