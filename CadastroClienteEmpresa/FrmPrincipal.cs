using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                FrmCadCliente cadCli = new FrmCadCliente();

                // Mostra o fomulário instanciado
                cadCli.Show();
            } else { 
            // Instancia a classe do FrmCadCliente
                FrmCadEmpresa cadEmp = new FrmCadEmpresa();

                // Mostra o fomulário instanciado
                cadEmp.Show();
            }
        }
    }
}
