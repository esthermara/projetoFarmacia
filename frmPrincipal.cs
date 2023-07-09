using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoFarmacia
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadrastrarPessoas_Click(object sender, EventArgs e)
        {
            frmCadastrarPessoa frmCP = new frmCadastrarPessoa();
            frmCP.Show();
        }

        private void btnCadastrarEstoque_Click(object sender, EventArgs e)
        {
            frmCadastroEstoque frmCE = new frmCadastroEstoque();
            frmCE.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
