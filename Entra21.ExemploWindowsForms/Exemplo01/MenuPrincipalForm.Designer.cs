namespace Entra21.ExemploWindowsForms.Exemplo01
{
    partial class MenuPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.buttonEnderecos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonPacientes.Image")));
            this.buttonPacientes.Location = new System.Drawing.Point(308, 15);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(252, 294);
            this.buttonPacientes.TabIndex = 0;
            this.buttonPacientes.Text = "Pacientes";
            this.buttonPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPacientes.UseVisualStyleBackColor = true;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // buttonEnderecos
            // 
            this.buttonEnderecos.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnderecos.Image")));
            this.buttonEnderecos.Location = new System.Drawing.Point(12, 12);
            this.buttonEnderecos.Name = "buttonEnderecos";
            this.buttonEnderecos.Size = new System.Drawing.Size(280, 297);
            this.buttonEnderecos.TabIndex = 1;
            this.buttonEnderecos.Text = "Endereços";
            this.buttonEnderecos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEnderecos.UseVisualStyleBackColor = true;
            this.buttonEnderecos.Click += new System.EventHandler(this.buttonEnderecos_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 354);
            this.Controls.Add(this.buttonEnderecos);
            this.Controls.Add(this.buttonPacientes);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Button buttonEnderecos;
    }
}