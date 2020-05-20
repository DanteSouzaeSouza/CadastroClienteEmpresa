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
            this.gpbCadastroEmp = new System.Windows.Forms.GroupBox();
            this.gpbEditarEmp = new System.Windows.Forms.GroupBox();
            this.gpbCadastroEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadastroEmp
            // 
            this.gpbCadastroEmp.Controls.Add(this.gpbEditarEmp);
            this.gpbCadastroEmp.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastroEmp.Name = "gpbCadastroEmp";
            this.gpbCadastroEmp.Size = new System.Drawing.Size(668, 534);
            this.gpbCadastroEmp.TabIndex = 0;
            this.gpbCadastroEmp.TabStop = false;
            this.gpbCadastroEmp.Text = "Cadastrar";
            // 
            // gpbEditarEmp
            // 
            this.gpbEditarEmp.Location = new System.Drawing.Point(654, 43);
            this.gpbEditarEmp.Name = "gpbEditarEmp";
            this.gpbEditarEmp.Size = new System.Drawing.Size(668, 534);
            this.gpbEditarEmp.TabIndex = 1;
            this.gpbEditarEmp.TabStop = false;
            this.gpbEditarEmp.Text = "Editar";
            // 
            // FrmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 558);
            this.Controls.Add(this.gpbCadastroEmp);
            this.Name = "FrmCadEmpresa";
            this.Text = "Cadastro de Empresa";
            this.Load += new System.EventHandler(this.FrmCadEmpresa_Load);
            this.gpbCadastroEmp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastroEmp;
        private System.Windows.Forms.GroupBox gpbEditarEmp;
    }
}