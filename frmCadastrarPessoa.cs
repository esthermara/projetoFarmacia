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
    public partial class frmCadastrarPessoa : Form
    {
        public frmCadastrarPessoa()
        {
            InitializeComponent();
        }

        private void cadastroPessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroPessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaFarmaciaDataSet);

        }

        private void frmCadastrarPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaFarmaciaDataSet.cadastroPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroPessoaTableAdapter.Fill(this.sistemaFarmaciaDataSet.cadastroPessoa);

        }
    }
}
