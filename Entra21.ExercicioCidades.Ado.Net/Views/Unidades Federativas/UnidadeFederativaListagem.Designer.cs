namespace Entra21.ExercicioCidades.Ado.Net.Views.Unidades_Federativas
{
    partial class UnidadeFederativaListagem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnSigla});
            this.dataGridView1.Location = new System.Drawing.Point(194, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(372, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnSigla
            // 
            this.ColumnSigla.HeaderText = "Sigla";
            this.ColumnSigla.Name = "ColumnSigla";
            this.ColumnSigla.ReadOnly = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 12);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(130, 34);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(12, 52);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(130, 38);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 96);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(130, 38);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // UnidadeFederativaListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 401);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UnidadeFederativaListagem";
            this.Text = "UnidadeFederativaListagem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnSigla;
        private Button buttonSalvar;
        private Button buttonEditar;
        private Button buttonCancelar;
    }
}