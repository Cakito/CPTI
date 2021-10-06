
namespace View
{
    partial class CadEmpr
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
            this.gpbEmpr = new System.Windows.Forms.GroupBox();
            this.mtbEmpr = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.lblUsuCpfEmpr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.mtbDataDevol = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataEmpr = new System.Windows.Forms.MaskedTextBox();
            this.lblIdEmpr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDataDevol = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDataEmpr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbIdEmpr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCancelEmpr = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnConfirmEmpr = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTituloEmpr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblTituloEmpr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gpbEmpr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEmpr
            // 
            this.gpbEmpr.Controls.Add(this.label1);
            this.gpbEmpr.Controls.Add(this.lblTituloEmpr);
            this.gpbEmpr.Controls.Add(this.txbTituloEmpr);
            this.gpbEmpr.Controls.Add(this.mtbEmpr);
            this.gpbEmpr.Controls.Add(this.lblUsuCpfEmpr);
            this.gpbEmpr.Controls.Add(this.mtbDataDevol);
            this.gpbEmpr.Controls.Add(this.mtbDataEmpr);
            this.gpbEmpr.Controls.Add(this.lblIdEmpr);
            this.gpbEmpr.Controls.Add(this.lblDataDevol);
            this.gpbEmpr.Controls.Add(this.lblDataEmpr);
            this.gpbEmpr.Controls.Add(this.txbIdEmpr);
            this.gpbEmpr.Location = new System.Drawing.Point(23, 23);
            this.gpbEmpr.Name = "gpbEmpr";
            this.gpbEmpr.Size = new System.Drawing.Size(615, 244);
            this.gpbEmpr.TabIndex = 11;
            this.gpbEmpr.TabStop = false;
            this.gpbEmpr.Text = "Dados do Empréstimo";
            // 
            // mtbEmpr
            // 
            this.mtbEmpr.Location = new System.Drawing.Point(92, 175);
            this.mtbEmpr.Name = "mtbEmpr";
            this.mtbEmpr.Size = new System.Drawing.Size(119, 23);
            this.mtbEmpr.TabIndex = 18;
            // 
            // lblUsuCpfEmpr
            // 
            this.lblUsuCpfEmpr.Location = new System.Drawing.Point(10, 178);
            this.lblUsuCpfEmpr.Name = "lblUsuCpfEmpr";
            this.lblUsuCpfEmpr.Size = new System.Drawing.Size(79, 20);
            this.lblUsuCpfEmpr.TabIndex = 17;
            this.lblUsuCpfEmpr.Values.Text = "Usuário CPF:";
            // 
            // mtbDataDevol
            // 
            this.mtbDataDevol.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mtbDataDevol.Location = new System.Drawing.Point(464, 131);
            this.mtbDataDevol.Mask = "00/00/0000";
            this.mtbDataDevol.Name = "mtbDataDevol";
            this.mtbDataDevol.Size = new System.Drawing.Size(116, 20);
            this.mtbDataDevol.TabIndex = 16;
            this.mtbDataDevol.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataEmpr
            // 
            this.mtbDataEmpr.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mtbDataEmpr.Location = new System.Drawing.Point(464, 70);
            this.mtbDataEmpr.Mask = "00/00/0000";
            this.mtbDataEmpr.Name = "mtbDataEmpr";
            this.mtbDataEmpr.Size = new System.Drawing.Size(116, 20);
            this.mtbDataEmpr.TabIndex = 15;
            this.mtbDataEmpr.ValidatingType = typeof(System.DateTime);
            // 
            // lblIdEmpr
            // 
            this.lblIdEmpr.Location = new System.Drawing.Point(61, 70);
            this.lblIdEmpr.Name = "lblIdEmpr";
            this.lblIdEmpr.Size = new System.Drawing.Size(25, 20);
            this.lblIdEmpr.TabIndex = 14;
            this.lblIdEmpr.Values.Text = "ID:";
            // 
            // lblDataDevol
            // 
            this.lblDataDevol.Location = new System.Drawing.Point(342, 131);
            this.lblDataDevol.Name = "lblDataDevol";
            this.lblDataDevol.Size = new System.Drawing.Size(116, 20);
            this.lblDataDevol.TabIndex = 13;
            this.lblDataDevol.Values.Text = "Data da Devolução:";
            // 
            // lblDataEmpr
            // 
            this.lblDataEmpr.Location = new System.Drawing.Point(337, 70);
            this.lblDataEmpr.Name = "lblDataEmpr";
            this.lblDataEmpr.Size = new System.Drawing.Size(125, 20);
            this.lblDataEmpr.TabIndex = 12;
            this.lblDataEmpr.Values.Text = "Data do Empréstimo:";
            // 
            // txbIdEmpr
            // 
            this.txbIdEmpr.Location = new System.Drawing.Point(92, 67);
            this.txbIdEmpr.Name = "txbIdEmpr";
            this.txbIdEmpr.Size = new System.Drawing.Size(116, 23);
            this.txbIdEmpr.TabIndex = 11;
            // 
            // btnCancelEmpr
            // 
            this.btnCancelEmpr.Location = new System.Drawing.Point(176, 282);
            this.btnCancelEmpr.Name = "btnCancelEmpr";
            this.btnCancelEmpr.Size = new System.Drawing.Size(90, 25);
            this.btnCancelEmpr.TabIndex = 18;
            this.btnCancelEmpr.Values.Text = "Cancelar";
            // 
            // btnConfirmEmpr
            // 
            this.btnConfirmEmpr.Location = new System.Drawing.Point(391, 282);
            this.btnConfirmEmpr.Name = "btnConfirmEmpr";
            this.btnConfirmEmpr.Size = new System.Drawing.Size(90, 25);
            this.btnConfirmEmpr.TabIndex = 17;
            this.btnConfirmEmpr.Values.Text = "Confirmar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(113, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "CPF inválido";
            this.label1.Visible = false;
            // 
            // txbTituloEmpr
            // 
            this.txbTituloEmpr.Location = new System.Drawing.Point(92, 114);
            this.txbTituloEmpr.Name = "txbTituloEmpr";
            this.txbTituloEmpr.Size = new System.Drawing.Size(191, 23);
            this.txbTituloEmpr.TabIndex = 19;
            // 
            // lblTituloEmpr
            // 
            this.lblTituloEmpr.Location = new System.Drawing.Point(45, 117);
            this.lblTituloEmpr.Name = "lblTituloEmpr";
            this.lblTituloEmpr.Size = new System.Drawing.Size(44, 20);
            this.lblTituloEmpr.TabIndex = 20;
            this.lblTituloEmpr.Values.Text = "Título:";
            // 
            // CadEmpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 319);
            this.Controls.Add(this.btnCancelEmpr);
            this.Controls.Add(this.gpbEmpr);
            this.Controls.Add(this.btnConfirmEmpr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadEmpr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Empréstimo";
            this.gpbEmpr.ResumeLayout(false);
            this.gpbEmpr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEmpr;
        private System.Windows.Forms.MaskedTextBox mtbDataDevol;
        private System.Windows.Forms.MaskedTextBox mtbDataEmpr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblIdEmpr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDataDevol;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDataEmpr;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbIdEmpr;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelEmpr;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfirmEmpr;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox mtbEmpr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUsuCpfEmpr;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTituloEmpr;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbTituloEmpr;
    }
}