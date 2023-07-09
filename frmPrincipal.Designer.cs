namespace projetoFarmacia
{
    partial class frmPrincipal
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
            this.btnCadrastrarPessoas = new System.Windows.Forms.Button();
            this.btnCadastrarEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadrastrarPessoas
            // 
            this.btnCadrastrarPessoas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadrastrarPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadrastrarPessoas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadrastrarPessoas.Location = new System.Drawing.Point(112, 133);
            this.btnCadrastrarPessoas.Name = "btnCadrastrarPessoas";
            this.btnCadrastrarPessoas.Size = new System.Drawing.Size(236, 178);
            this.btnCadrastrarPessoas.TabIndex = 0;
            this.btnCadrastrarPessoas.Text = "Cadastro de Clientes";
            this.btnCadrastrarPessoas.UseVisualStyleBackColor = true;
            this.btnCadrastrarPessoas.Click += new System.EventHandler(this.btnCadrastrarPessoas_Click);
            // 
            // btnCadastrarEstoque
            // 
            this.btnCadastrarEstoque.BackColor = System.Drawing.Color.Turquoise;
            this.btnCadastrarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEstoque.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEstoque.Location = new System.Drawing.Point(381, 133);
            this.btnCadastrarEstoque.Name = "btnCadastrarEstoque";
            this.btnCadastrarEstoque.Size = new System.Drawing.Size(240, 178);
            this.btnCadastrarEstoque.TabIndex = 1;
            this.btnCadastrarEstoque.Text = "Cadastro Estoque";
            this.btnCadastrarEstoque.UseVisualStyleBackColor = false;
            this.btnCadastrarEstoque.Click += new System.EventHandler(this.btnCadastrarEstoque_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarEstoque);
            this.Controls.Add(this.btnCadrastrarPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadrastrarPessoas;
        private System.Windows.Forms.Button btnCadastrarEstoque;
    }
}