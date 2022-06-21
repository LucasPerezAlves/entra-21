namespace Entra21.ExemploWindowsForms.Exemplo01
{
    partial class EnderecosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEnderecos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCEP = new System.Windows.Forms.Label();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.labelEnderecoCompleto = new System.Windows.Forms.Label();
            this.textBoxEnderecoCompleto = new System.Windows.Forms.TextBox();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnderecos
            // 
            this.labelEnderecos.AutoSize = true;
            this.labelEnderecos.Location = new System.Drawing.Point(12, 18);
            this.labelEnderecos.Name = "labelEnderecos";
            this.labelEnderecos.Size = new System.Drawing.Size(73, 16);
            this.labelEnderecos.TabIndex = 0;
            this.labelEnderecos.Text = "Endereços";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 412);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(441, 37);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(34, 16);
            this.labelCEP.TabIndex = 2;
            this.labelCEP.Text = "CEP";
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(441, 56);
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(134, 22);
            this.maskedTextBoxCEP.TabIndex = 3;
            // 
            // labelEnderecoCompleto
            // 
            this.labelEnderecoCompleto.AutoSize = true;
            this.labelEnderecoCompleto.Location = new System.Drawing.Point(441, 98);
            this.labelEnderecoCompleto.Name = "labelEnderecoCompleto";
            this.labelEnderecoCompleto.Size = new System.Drawing.Size(127, 16);
            this.labelEnderecoCompleto.TabIndex = 4;
            this.labelEnderecoCompleto.Text = "Endereço Completo";
            // 
            // textBoxEnderecoCompleto
            // 
            this.textBoxEnderecoCompleto.Location = new System.Drawing.Point(441, 127);
            this.textBoxEnderecoCompleto.Name = "textBoxEnderecoCompleto";
            this.textBoxEnderecoCompleto.Size = new System.Drawing.Size(347, 22);
            this.textBoxEnderecoCompleto.TabIndex = 5;
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(441, 161);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(60, 16);
            this.labelPaciente.TabIndex = 6;
            this.labelPaciente.Text = "Paciente";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(618, 221);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(713, 221);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(441, 191);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(344, 24);
            this.comboBoxPaciente.TabIndex = 10;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(268, 8);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 11;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(360, 8);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 12;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // EnderecosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelPaciente);
            this.Controls.Add(this.textBoxEnderecoCompleto);
            this.Controls.Add(this.labelEnderecoCompleto);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelEnderecos);
            this.Name = "EnderecosForm";
            this.Text = "EnderecosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnderecos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.Label labelEnderecoCompleto;
        private System.Windows.Forms.TextBox textBoxEnderecoCompleto;
        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonApagar;
    }
}