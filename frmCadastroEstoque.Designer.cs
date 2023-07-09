namespace projetoFarmacia
{
    partial class frmCadastroEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEstoque));
            System.Windows.Forms.Label estoqueIdLabel;
            System.Windows.Forms.Label quantidadeEstoqueLabel;
            System.Windows.Forms.Label descricaoEstoqueLabel;
            this.sistemaFarmaciaDataSet = new projetoFarmacia.sistemaFarmaciaDataSet();
            this.cadastroEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroEstoqueTableAdapter = new projetoFarmacia.sistemaFarmaciaDataSetTableAdapters.cadastroEstoqueTableAdapter();
            this.tableAdapterManager = new projetoFarmacia.sistemaFarmaciaDataSetTableAdapters.TableAdapterManager();
            this.cadastroEstoqueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cadastroEstoqueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cadastroEstoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.estoqueIdTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeEstoqueTextBox = new System.Windows.Forms.TextBox();
            this.descricaoEstoqueTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estoqueIdLabel = new System.Windows.Forms.Label();
            quantidadeEstoqueLabel = new System.Windows.Forms.Label();
            descricaoEstoqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFarmaciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEstoqueBindingNavigator)).BeginInit();
            this.cadastroEstoqueBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEstoqueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaFarmaciaDataSet
            // 
            this.sistemaFarmaciaDataSet.DataSetName = "sistemaFarmaciaDataSet";
            this.sistemaFarmaciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroEstoqueBindingSource
            // 
            this.cadastroEstoqueBindingSource.DataMember = "cadastroEstoque";
            this.cadastroEstoqueBindingSource.DataSource = this.sistemaFarmaciaDataSet;
            // 
            // cadastroEstoqueTableAdapter
            // 
            this.cadastroEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadastroEstoqueTableAdapter = this.cadastroEstoqueTableAdapter;
            this.tableAdapterManager.cadastroPessoaTableAdapter = null;
            this.tableAdapterManager.casdastroMedicamentosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projetoFarmacia.sistemaFarmaciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastroEstoqueBindingNavigator
            // 
            this.cadastroEstoqueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadastroEstoqueBindingNavigator.BindingSource = this.cadastroEstoqueBindingSource;
            this.cadastroEstoqueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadastroEstoqueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadastroEstoqueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cadastroEstoqueBindingNavigatorSaveItem});
            this.cadastroEstoqueBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadastroEstoqueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadastroEstoqueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadastroEstoqueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadastroEstoqueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadastroEstoqueBindingNavigator.Name = "cadastroEstoqueBindingNavigator";
            this.cadastroEstoqueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadastroEstoqueBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.cadastroEstoqueBindingNavigator.TabIndex = 0;
            this.cadastroEstoqueBindingNavigator.Text = "bindingNavigator1";
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
            // cadastroEstoqueBindingNavigatorSaveItem
            // 
            this.cadastroEstoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadastroEstoqueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroEstoqueBindingNavigatorSaveItem.Image")));
            this.cadastroEstoqueBindingNavigatorSaveItem.Name = "cadastroEstoqueBindingNavigatorSaveItem";
            this.cadastroEstoqueBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cadastroEstoqueBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadastroEstoqueBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadastroEstoqueBindingNavigatorSaveItem_Click);
            // 
            // cadastroEstoqueDataGridView
            // 
            this.cadastroEstoqueDataGridView.AllowUserToAddRows = false;
            this.cadastroEstoqueDataGridView.AllowUserToDeleteRows = false;
            this.cadastroEstoqueDataGridView.AutoGenerateColumns = false;
            this.cadastroEstoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadastroEstoqueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cadastroEstoqueDataGridView.DataSource = this.cadastroEstoqueBindingSource;
            this.cadastroEstoqueDataGridView.Location = new System.Drawing.Point(20, 145);
            this.cadastroEstoqueDataGridView.Name = "cadastroEstoqueDataGridView";
            this.cadastroEstoqueDataGridView.ReadOnly = true;
            this.cadastroEstoqueDataGridView.Size = new System.Drawing.Size(788, 286);
            this.cadastroEstoqueDataGridView.TabIndex = 1;
            // 
            // estoqueIdLabel
            // 
            estoqueIdLabel.AutoSize = true;
            estoqueIdLabel.Location = new System.Drawing.Point(478, 38);
            estoqueIdLabel.Name = "estoqueIdLabel";
            estoqueIdLabel.Size = new System.Drawing.Size(61, 13);
            estoqueIdLabel.TabIndex = 2;
            estoqueIdLabel.Text = "Estoque Id:";
            // 
            // estoqueIdTextBox
            // 
            this.estoqueIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroEstoqueBindingSource, "EstoqueId", true));
            this.estoqueIdTextBox.Location = new System.Drawing.Point(591, 35);
            this.estoqueIdTextBox.Name = "estoqueIdTextBox";
            this.estoqueIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.estoqueIdTextBox.TabIndex = 3;
            // 
            // quantidadeEstoqueLabel
            // 
            quantidadeEstoqueLabel.AutoSize = true;
            quantidadeEstoqueLabel.Location = new System.Drawing.Point(478, 64);
            quantidadeEstoqueLabel.Name = "quantidadeEstoqueLabel";
            quantidadeEstoqueLabel.Size = new System.Drawing.Size(107, 13);
            quantidadeEstoqueLabel.TabIndex = 4;
            quantidadeEstoqueLabel.Text = "Quantidade Estoque:";
            // 
            // quantidadeEstoqueTextBox
            // 
            this.quantidadeEstoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroEstoqueBindingSource, "QuantidadeEstoque", true));
            this.quantidadeEstoqueTextBox.Location = new System.Drawing.Point(591, 61);
            this.quantidadeEstoqueTextBox.Name = "quantidadeEstoqueTextBox";
            this.quantidadeEstoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeEstoqueTextBox.TabIndex = 5;
            // 
            // descricaoEstoqueLabel
            // 
            descricaoEstoqueLabel.AutoSize = true;
            descricaoEstoqueLabel.Location = new System.Drawing.Point(478, 90);
            descricaoEstoqueLabel.Name = "descricaoEstoqueLabel";
            descricaoEstoqueLabel.Size = new System.Drawing.Size(100, 13);
            descricaoEstoqueLabel.TabIndex = 6;
            descricaoEstoqueLabel.Text = "Descricao Estoque:";
            // 
            // descricaoEstoqueTextBox
            // 
            this.descricaoEstoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroEstoqueBindingSource, "DescricaoEstoque", true));
            this.descricaoEstoqueTextBox.Location = new System.Drawing.Point(591, 87);
            this.descricaoEstoqueTextBox.Name = "descricaoEstoqueTextBox";
            this.descricaoEstoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoEstoqueTextBox.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EstoqueId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificação";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QuantidadeEstoque";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescricaoEstoque";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 445;
            // 
            // frmCadastroEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 458);
            this.Controls.Add(estoqueIdLabel);
            this.Controls.Add(this.estoqueIdTextBox);
            this.Controls.Add(quantidadeEstoqueLabel);
            this.Controls.Add(this.quantidadeEstoqueTextBox);
            this.Controls.Add(descricaoEstoqueLabel);
            this.Controls.Add(this.descricaoEstoqueTextBox);
            this.Controls.Add(this.cadastroEstoqueDataGridView);
            this.Controls.Add(this.cadastroEstoqueBindingNavigator);
            this.Name = "frmCadastroEstoque";
            this.Text = "frmCadastroEstoque";
            this.Load += new System.EventHandler(this.frmCadastroEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaFarmaciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEstoqueBindingNavigator)).EndInit();
            this.cadastroEstoqueBindingNavigator.ResumeLayout(false);
            this.cadastroEstoqueBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroEstoqueDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistemaFarmaciaDataSet sistemaFarmaciaDataSet;
        private System.Windows.Forms.BindingSource cadastroEstoqueBindingSource;
        private sistemaFarmaciaDataSetTableAdapters.cadastroEstoqueTableAdapter cadastroEstoqueTableAdapter;
        private sistemaFarmaciaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cadastroEstoqueBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cadastroEstoqueBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cadastroEstoqueDataGridView;
        private System.Windows.Forms.TextBox estoqueIdTextBox;
        private System.Windows.Forms.TextBox quantidadeEstoqueTextBox;
        private System.Windows.Forms.TextBox descricaoEstoqueTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}