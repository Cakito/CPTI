
namespace View
{
    partial class AlterEditora
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
            this.dgvEditora = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnAlterSalvarEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAlterExcluirLivro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAlterFechar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblAlterEditora = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbAlterEditora = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.colAlterIdEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlterNomeEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditora
            // 
            this.dgvEditora.AllowUserToAddRows = false;
            this.dgvEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlterIdEdit,
            this.colAlterNomeEdit});
            this.dgvEditora.Location = new System.Drawing.Point(34, 79);
            this.dgvEditora.Name = "dgvEditora";
            this.dgvEditora.RowHeadersVisible = false;
            this.dgvEditora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditora.Size = new System.Drawing.Size(404, 402);
            this.dgvEditora.TabIndex = 0;
            // 
            // btnAlterSalvarEdit
            // 
            this.btnAlterSalvarEdit.Location = new System.Drawing.Point(34, 515);
            this.btnAlterSalvarEdit.Name = "btnAlterSalvarEdit";
            this.btnAlterSalvarEdit.Size = new System.Drawing.Size(122, 25);
            this.btnAlterSalvarEdit.TabIndex = 1;
            this.btnAlterSalvarEdit.Values.Text = "Salvar Alterações";
            // 
            // btnAlterExcluirLivro
            // 
            this.btnAlterExcluirLivro.Location = new System.Drawing.Point(186, 515);
            this.btnAlterExcluirLivro.Name = "btnAlterExcluirLivro";
            this.btnAlterExcluirLivro.Size = new System.Drawing.Size(80, 25);
            this.btnAlterExcluirLivro.TabIndex = 2;
            this.btnAlterExcluirLivro.Values.Text = "Excluir";
            // 
            // btnAlterFechar
            // 
            this.btnAlterFechar.Location = new System.Drawing.Point(360, 515);
            this.btnAlterFechar.Name = "btnAlterFechar";
            this.btnAlterFechar.Size = new System.Drawing.Size(78, 25);
            this.btnAlterFechar.TabIndex = 3;
            this.btnAlterFechar.Values.Text = "Fechar";
            // 
            // lblAlterEditora
            // 
            this.lblAlterEditora.Location = new System.Drawing.Point(82, 39);
            this.lblAlterEditora.Name = "lblAlterEditora";
            this.lblAlterEditora.Size = new System.Drawing.Size(97, 20);
            this.lblAlterEditora.TabIndex = 4;
            this.lblAlterEditora.Values.Text = "Digite a Editora:";
            // 
            // txbAlterEditora
            // 
            this.txbAlterEditora.Location = new System.Drawing.Point(175, 36);
            this.txbAlterEditora.Name = "txbAlterEditora";
            this.txbAlterEditora.Size = new System.Drawing.Size(199, 23);
            this.txbAlterEditora.TabIndex = 5;
            // 
            // colAlterIdEdit
            // 
            this.colAlterIdEdit.HeaderText = "ID";
            this.colAlterIdEdit.Name = "colAlterIdEdit";
            this.colAlterIdEdit.Width = 200;
            // 
            // colAlterNomeEdit
            // 
            this.colAlterNomeEdit.HeaderText = "Editora";
            this.colAlterNomeEdit.Name = "colAlterNomeEdit";
            this.colAlterNomeEdit.Width = 200;
            // 
            // AlterEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 552);
            this.Controls.Add(this.txbAlterEditora);
            this.Controls.Add(this.lblAlterEditora);
            this.Controls.Add(this.btnAlterFechar);
            this.Controls.Add(this.btnAlterExcluirLivro);
            this.Controls.Add(this.btnAlterSalvarEdit);
            this.Controls.Add(this.dgvEditora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AlterEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar / Excluir Editora";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEditora;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAlterSalvarEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAlterExcluirLivro;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAlterFechar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAlterEditora;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbAlterEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlterIdEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlterNomeEdit;
    }
}