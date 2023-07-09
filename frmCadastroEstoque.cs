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
    public partial class frmCadastroEstoque : Form
    {
        public frmCadastroEstoque()
        {
            InitializeComponent();
        }

        private void cadastroEstoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroEstoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaFarmaciaDataSet);

        }

        private void frmCadastroEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaFarmaciaDataSet.cadastroEstoque'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroEstoqueTableAdapter.Fill(this.sistemaFarmaciaDataSet.cadastroEstoque);

        }
    }
}
