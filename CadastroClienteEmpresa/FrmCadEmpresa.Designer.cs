namespace CadastroClienteEmpresa
{
    partial class FrmCadEmpresa
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
            this.tbCEmpresa = new System.Windows.Forms.TabControl();
            this.tabPCadastro = new System.Windows.Forms.TabPage();
            this.tbCEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCEmpresa
            // 
            this.tbCEmpresa.Controls.Add(this.tabPCadastro);
            this.tbCEmpresa.Location = new System.Drawing.Point(9, 1);
            this.tbCEmpresa.Name = "tbCEmpresa";
            this.tbCEmpresa.SelectedIndex = 0;
            this.tbCEmpresa.Size = new System.Drawing.Size(671, 549);
            this.tbCEmpresa.TabIndex = 1;
            // 
            // tabPCadastro
            // 
            this.tabPCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPCadastro.Name = "tabPCadastro";
            this.tabPCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCadastro.Size = new System.Drawing.Size(663, 523);
            this.tabPCadastro.TabIndex = 0;
            this.tabPCadastro.Text = "Dados";
            this.tabPCadastro.UseVisualStyleBackColor = true;
            // 
            // FrmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 558);
            this.Controls.Add(this.tbCEmpresa);
            this.Name = "FrmCadEmpresa";
            this.Text = "Cadastro de Empresa";
            this.Load += new System.EventHandler(this.FrmCadEmpresa_Load);
            this.tbCEmpresa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCEmpresa;
        private System.Windows.Forms.TabPage tabPCadastro;
    }
}