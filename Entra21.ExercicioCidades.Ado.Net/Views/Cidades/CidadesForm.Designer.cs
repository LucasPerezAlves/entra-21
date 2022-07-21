namespace Entra21.ExercicioCidades.Ado.Net.Views
{
    partial class CidadesForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelQuantidadeHabitantes = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDataHoraFundacao = new System.Windows.Forms.Label();
            this.labelPib = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxQuantidadeHabitantes = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelQuantidadeHabitantes
            // 
            this.labelQuantidadeHabitantes.AutoSize = true;
            this.labelQuantidadeHabitantes.Location = new System.Drawing.Point(12, 64);
            this.labelQuantidadeHabitantes.Name = "labelQuantidadeHabitantes";
            this.labelQuantidadeHabitantes.Size = new System.Drawing.Size(144, 15);
            this.labelQuantidadeHabitantes.TabIndex = 2;
            this.labelQuantidadeHabitantes.Text = "Quantidade De habitantes";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labelDataHoraFundacao
            // 
            this.labelDataHoraFundacao.AutoSize = true;
            this.labelDataHoraFundacao.Location = new System.Drawing.Point(12, 120);
            this.labelDataHoraFundacao.Name = "labelDataHoraFundacao";
            this.labelDataHoraFundacao.Size = new System.Drawing.Size(136, 15);
            this.labelDataHoraFundacao.TabIndex = 5;
            this.labelDataHoraFundacao.Text = "Data e hora da fundação";
            // 
            // labelPib
            // 
            this.labelPib.AutoSize = true;
            this.labelPib.Location = new System.Drawing.Point(12, 173);
            this.labelPib.Name = "labelPib";
            this.labelPib.Size = new System.Drawing.Size(24, 15);
            this.labelPib.TabIndex = 6;
            this.labelPib.Text = "Pib";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 191);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 23);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // maskedTextBoxQuantidadeHabitantes
            // 
            this.maskedTextBoxQuantidadeHabitantes.Location = new System.Drawing.Point(12, 82);
            this.maskedTextBoxQuantidadeHabitantes.Name = "maskedTextBoxQuantidadeHabitantes";
            this.maskedTextBoxQuantidadeHabitantes.Size = new System.Drawing.Size(200, 23);
            this.maskedTextBoxQuantidadeHabitantes.TabIndex = 8;
            // 
            // CidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 478);
            this.Controls.Add(this.maskedTextBoxQuantidadeHabitantes);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelPib);
            this.Controls.Add(this.labelDataHoraFundacao);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelQuantidadeHabitantes);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "CidadesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CidadesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelQuantidadeHabitantes;
        private DateTimePicker dateTimePicker1;
        private Label labelDataHoraFundacao;
        private Label labelPib;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBoxQuantidadeHabitantes;
    }
}