
namespace View
{
    partial class AlterLivro
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
            this.dgvLivro = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colAlterIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlterTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlterAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlterEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlterEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlterAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAlterLivro = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbAlterLivro = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAlterSalvarLivro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAlterExcluirLivro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAlterLivroFechar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivro
            // 
            this.dgvLivro.AllowUserToAddRows = false;
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlterIsbn,
            this.colAlterTitulo,
            this.colAlterAno,
            this.colAlterEdicao,
            this.colAlterEditora,
            this.colAlterAutor});
            this.dgvLivro.Location = new System.Drawing.Point(42, 86);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.RowHeadersVisible = false;
            this.dgvLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivro.Size = new System.Drawing.Size(763, 475);
            this.dgvLivro.TabIndex = 0;
            // 
            // colAlterIsbn
            // 
            this.colAlterIsbn.HeaderText = "ISBN";
            this.colAlterIsbn.Name = "colAlterIsbn";
            this.colAlterIsbn.Width = 150;
            // 
            // colAlterTitulo
            // 
            this.colAlterTitulo.HeaderText = "Título";
            this.colAlterTitulo.Name = "colAlterTitulo";
            this.colAlterTitulo.Width = 150;
            // 
            // colAlterAno
            // 
            this.colAlterAno.HeaderText = "Ano";
            this.colAlterAno.Name = "colAlterAno";
            this.colAlterAno.Width = 80;
            // 
            // colAlterEdicao
            // 
            this.colAlterEdicao.HeaderText = "Edição";
            this.colAlterEdicao.Name = "colAlterEdicao";
            this.colAlterEdicao.Width = 80;
            // 
            // colAlterEditora
            // 
            this.colAlterEditora.HeaderText = "Editora";
            this.colAlterEditora.Name = "colAlterEditora";
            this.colAlterEditora.Width = 150;
            // 
            // colAlterAutor
            // 
            this.colAlterAutor.HeaderText = "Autor";
            this.colAlterAutor.Name = "colAlterAutor";
            this.colAlterAutor.Width = 150;
            // 
            // lblAlterLivro
            // 
            this.lblAlterLivro.Location = new System.Drawing.Point(200, 42);
            this.lblAlterLivro.Name = "lblAlterLivro";
            this.lblAlterLivro.Size = new System.Drawing.Size(91, 20);
            this.lblAlterLivro.TabIndex = 1;
            this.lblAlterLivro.Values.Text = "Digite o Título:";
            // 
            // txbAlterLivro
            // 
            this.txbAlterLivro.Location = new System.Drawing.Point(294, 39);
            this.txbAlterLivro.Name = "txbAlterLivro";
            this.txbAlterLivro.Size = new System.Drawing.Size(279, 23);
            this.txbAlterLivro.TabIndex = 2;
            // 
            // btnAlterSalvarLivro
            // 
            this.btnAlterSalvarLivro.Location = new System.Drawing.Point(42, 582);
            this.btnAlterSalvarLivro.Name = "btnAlterSalvarLivro";
            this.btnAlterSalvarLivro.Size = new System.Drawing.Size(120, 25);
            this.btnAlterSalvarLivro.TabIndex = 3;
            this.btnAlterSalvarLivro.Values.Text = "Salvar Alterações";
            // 
            // btnAlterExcluirLivro
            // 
            this.btnAlterExcluirLivro.Location = new System.Drawing.Point(212, 582);
            this.btnAlterExcluirLivro.Name = "btnAlterExcluirLivro";
            this.btnAlterExcluirLivro.Size = new System.Drawing.Size(90, 25);
            this.btnAlterExcluirLivro.TabIndex = 4;
            this.btnAlterExcluirLivro.Values.Text = "Excluir";
            // 
            // btnAlterLivroFechar
            // 
            this.btnAlterLivroFechar.Location = new System.Drawing.Point(715, 582);
            this.btnAlterLivroFechar.Name = "btnAlterLivroFechar";
            this.btnAlterLivroFechar.Size = new System.Drawing.Size(90, 25);
            this.btnAlterLivroFechar.TabIndex = 5;
            this.btnAlterLivroFechar.Values.Text = "Fechar";
            // 
            // AlterLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 619);
            this.Controls.Add(this.btnAlterLivroFechar);
            this.Controls.Add(this.btnAlterExcluirLivro);
            this.Controls.Add(this.btnAlterSalvarLivro);
            this.Controls.Add(this.txbAlterLivro);
            this.Controls.Add(this.lblAlterLivro);
            this.Controls.Add(this.dgvLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AlterLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar / Excluir Livro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvLivro;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAlterLivro;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbAlterLivro;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAlterSalvarLivro;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAlterExcluirLivro;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAlterLivroFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlterIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlterTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlterAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlterEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlterEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlterAutor;
    }
}