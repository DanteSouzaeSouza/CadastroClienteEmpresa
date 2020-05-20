using System;
using System.Windows.Forms;

namespace CadastroClienteEmpresa
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (rdBtnCliente.Checked)
            {
                // Instancia a classe do FrmCadCliente
                var cadCli = new FrmCadCliente();

                // Mostra o fomulário instanciado
                cadCli.Show();
            }
            else
            {
                // Instancia a classe do FrmCadCliente
                var cadEmp = new FrmCadEmpresa();

                // Mostra o fomulário instanciado
                cadEmp.Show();
            }
        }
    }
}