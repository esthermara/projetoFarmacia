namespace projetoFarmacia
{
    partial class frmCadastrarPessoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarPessoa));
            System.Windows.Forms.Label pessoaIdLabel;
            System.Windows.Forms.Label nomePessoaLabel;
            System.Windows.Forms.Label idadePessoaLabel;
            System.Windows.Forms.Label alturaPessoaLabel;
            this.sistemaFarmaciaDataSet = new projetoFarmacia.sistemaFarmaciaDataSet();
            this.cadastroPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroPessoaTableAdapter = new projetoFarmacia.sistemaFarmaciaDataSetTableAdapters.cadastroPessoaTableAdapter();
            this.tableAdapterManager = new projetoFarmacia.sistemaFarmaciaDataSetTableAdapters.TableAdapterManager();
            this.cadastroPessoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cadastroPessoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cadastroPessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaIdTextBox = new System.Windows.Forms.TextBox();
            this.nomePessoaTextBox = new System.Windows.Forms.TextBox();
            this.idadePessoaTextBox = new System.Windows.Forms.TextBox();
            this.alturaPessoaTextBox = new System.Windows.Forms.TextBox();
            pessoaIdLabel = new System.Windows.Forms.Label();
            nomePessoaLabel = new System.Windows.Forms.Label();
            idadePessoaLabel = new System.Windows.Forms.Label();
            alturaPessoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFarmaciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPessoaBindingNavigator)).BeginInit();
            this.cadastroPessoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPessoaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaFarmaciaDataSet
            // 
            this.sistemaFarmaciaDataSet.DataSetName = "sistemaFarmaciaDataSet";
            this.sistemaFarmaciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroPessoaBindingSource
            // 
            this.cadastroPessoaBindingSource.DataMember = "cadastroPessoa";
            this.cadastroPessoaBindingSource.DataSource = this.sistemaFarmaciaDataSet;
            // 
            // cadastroPessoaTableAdapter
            // 
            this.cadastroPessoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastroEstoqueTableAdapter = null;
            this.tableAdapterManager.cadastroPessoaTableAdapter = this.cadastroPessoaTableAdapter;
            this.tableAdapterManager.casdastroMedicamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projetoFarmacia.sistemaFarmaciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastroPessoaBindingNavigator
            // 
            this.cadastroPessoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastroPessoaBindingNavigator.BindingSource = this.cadastroPessoaBindingSource;
            this.cadastroPessoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastroPessoaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastroPessoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cadastroPessoaBindingNavigatorSaveItem});
            this.cadastroPessoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastroPessoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastroPessoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastroPessoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastroPessoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastroPessoaBindingNavigator.Name = "cadastroPessoaBindingNavigator";
            this.cadastroPessoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastroPessoaBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.cadastroPessoaBindingNavigator.TabIndex = 0;
            this.cadastroPessoaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // cadastroPessoaBindingNavigatorSaveItem
            // 
            this.cadastroPessoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroPessoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroPessoaBindingNavigatorSaveItem.Image")));
            this.cadastroPessoaBindingNavigatorSaveItem.Name = "cadastroPessoaBindingNavigatorSaveItem";
            this.cadastroPessoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cadastroPessoaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadastroPessoaBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroPessoaBindingNavigatorSaveItem_Click);
            // 
            // cadastroPessoaDataGridView
            // 
            this.cadastroPessoaDataGridView.AutoGenerateColumns = false;
            this.cadastroPessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadastroPessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cadastroPessoaDataGridView.DataSource = this.cadastroPessoaBindingSource;
            this.cadastroPessoaDataGridView.Location = new System.Drawing.Point(341, 28);
            this.cadastroPessoaDataGridView.Name = "cadastroPessoaDataGridView";
            this.cadastroPessoaDataGridView.Size = new System.Drawing.Size(447, 395);
            this.cadastroPessoaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PessoaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PessoaId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomePessoa";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomePessoa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdadePessoa";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdadePessoa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AlturaPessoa";
            this.dataGridViewTextBoxColumn4.HeaderText = "AlturaPessoa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // pessoaIdLabel
            // 
            pessoaIdLabel.AutoSize = true;
            pessoaIdLabel.Location = new System.Drawing.Point(76, 141);
            pessoaIdLabel.Name = "pessoaIdLabel";
            pessoaIdLabel.Size = new System.Drawing.Size(57, 13);
            pessoaIdLabel.TabIndex = 2;
            pessoaIdLabel.Text = "Pessoa Id:";
            // 
            // pessoaIdTextBox
            // 
            this.pessoaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroPessoaBindingSource, "PessoaId", true));
            this.pessoaIdTextBox.Location = new System.Drawing.Point(158, 138);
            this.pessoaIdTextBox.Name = "pessoaIdTextBox";
            this.pessoaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.pessoaIdTextBox.TabIndex = 3;
            // 
            // nomePessoaLabel
            // 
            nomePessoaLabel.AutoSize = true;
            nomePessoaLabel.Location = new System.Drawing.Point(76, 167);
            nomePessoaLabel.Name = "nomePessoaLabel";
            nomePessoaLabel.Size = new System.Drawing.Size(76, 13);
            nomePessoaLabel.TabIndex = 4;
            nomePessoaLabel.Text = "Nome Pessoa:";
            // 
            // nomePessoaTextBox
            // 
            this.nomePessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroPessoaBindingSource, "NomePessoa", true));
            this.nomePessoaTextBox.Location = new System.Drawing.Point(158, 164);
            this.nomePessoaTextBox.Name = "nomePessoaTextBox";
            this.nomePessoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomePessoaTextBox.TabIndex = 5;
            // 
            // idadePessoaLabel
            // 
            idadePessoaLabel.AutoSize = true;
            idadePessoaLabel.Location = new System.Drawing.Point(76, 193);
            idadePessoaLabel.Name = "idadePessoaLabel";
            idadePessoaLabel.Size = new System.Drawing.Size(75, 13);
            idadePessoaLabel.TabIndex = 6;
            idadePessoaLabel.Text = "Idade Pessoa:";
            // 
            // idadePessoaTextBox
            // 
            this.idadePessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroPessoaBindingSource, "IdadePessoa", true));
            this.idadePessoaTextBox.Location = new System.Drawing.Point(158, 190);
            this.idadePessoaTextBox.Name = "idadePessoaTextBox";
            this.idadePessoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idadePessoaTextBox.TabIndex = 7;
            // 
            // alturaPessoaLabel
            // 
            alturaPessoaLabel.AutoSize = true;
            alturaPessoaLabel.Location = new System.Drawing.Point(76, 219);
            alturaPessoaLabel.Name = "alturaPessoaLabel";
            alturaPessoaLabel.Size = new System.Drawing.Size(75, 13);
            alturaPessoaLabel.TabIndex = 8;
            alturaPessoaLabel.Text = "Altura Pessoa:";
            // 
            // alturaPessoaTextBox
            // 
            this.alturaPessoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroPessoaBindingSource, "AlturaPessoa", true));
            this.alturaPessoaTextBox.Location = new System.Drawing.Point(158, 216);
            this.alturaPessoaTextBox.Name = "alturaPessoaTextBox";
            this.alturaPessoaTextBox.Size = new System.Drawing.Size(100, 20);
            this.alturaPessoaTextBox.TabIndex = 9;
            // 
            // frmCadastrarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(pessoaIdLabel);
            this.Controls.Add(this.pessoaIdTextBox);
            this.Controls.Add(nomePessoaLabel);
            this.Controls.Add(this.nomePessoaTextBox);
            this.Controls.Add(idadePessoaLabel);
            this.Controls.Add(this.idadePessoaTextBox);
            this.Controls.Add(alturaPessoaLabel);
            this.Controls.Add(this.alturaPessoaTextBox);
            this.Controls.Add(this.cadastroPessoaDataGridView);
            this.Controls.Add(this.cadastroPessoaBindingNavigator);
            this.Name = "frmCadastrarPessoa";
            this.Text = "frmCadastrarPessoa";
            this.Load += new System.EventHandler(this.frmCadastrarPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFarmaciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPessoaBindingNavigator)).EndInit();
            this.cadastroPessoaBindingNavigator.ResumeLayout(false);
            this.cadastroPessoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPessoaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistemaFarmaciaDataSet sistemaFarmaciaDataSet;
        private System.Windows.Forms.BindingSource cadastroPessoaBindingSource;
        private sistemaFarmaciaDataSetTableAdapters.cadastroPessoaTableAdapter cadastroPessoaTableAdapter;
        private sistemaFarmaciaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroPessoaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cadastroPessoaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cadastroPessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox pessoaIdTextBox;
        private System.Windows.Forms.TextBox nomePessoaTextBox;
        private System.Windows.Forms.TextBox idadePessoaTextBox;
        private System.Windows.Forms.TextBox alturaPessoaTextBox;
    }
}