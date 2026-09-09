namespace DonPdv.pdv.view
{
    partial class Frm_pagamento
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
            this.cb_pagamento = new System.Windows.Forms.ComboBox();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.tb_valorRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_troco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_aReceber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_pagamento
            // 
            this.cb_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pagamento.FormattingEnabled = true;
            this.cb_pagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix",
            "Crédito",
            "Débito",
            "Promissória"});
            this.cb_pagamento.Location = new System.Drawing.Point(161, 76);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(121, 21);
            this.cb_pagamento.TabIndex = 1;
            this.cb_pagamento.SelectedIndexChanged += new System.EventHandler(this.cb_pagamento_SelectedIndexChanged);
            this.cb_pagamento.Click += new System.EventHandler(this.cb_pagamento_Click);
            // 
            // btn_concluir
            // 
            this.btn_concluir.Location = new System.Drawing.Point(130, 258);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(119, 23);
            this.btn_concluir.TabIndex = 2;
            this.btn_concluir.Text = "Concluir";
            this.btn_concluir.UseVisualStyleBackColor = true;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // tb_valorRecebido
            // 
            this.tb_valorRecebido.Enabled = false;
            this.tb_valorRecebido.Location = new System.Drawing.Point(182, 132);
            this.tb_valorRecebido.Name = "tb_valorRecebido";
            this.tb_valorRecebido.Size = new System.Drawing.Size(100, 20);
            this.tb_valorRecebido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forma de Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Recebido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Troco";
            // 
            // tb_troco
            // 
            this.tb_troco.Enabled = false;
            this.tb_troco.Location = new System.Drawing.Point(182, 185);
            this.tb_troco.Name = "tb_troco";
            this.tb_troco.Size = new System.Drawing.Size(100, 20);
            this.tb_troco.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "A Receber";
            // 
            // tb_aReceber
            // 
            this.tb_aReceber.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tb_aReceber.Enabled = false;
            this.tb_aReceber.Location = new System.Drawing.Point(161, 23);
            this.tb_aReceber.Name = "tb_aReceber";
            this.tb_aReceber.Size = new System.Drawing.Size(121, 20);
            this.tb_aReceber.TabIndex = 8;
            // 
            // Frm_pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 319);
            this.Controls.Add(this.tb_aReceber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_troco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valorRecebido);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.cb_pagamento);
            this.KeyPreview = true;
            this.Name = "Frm_pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_pagamento";
            this.Load += new System.EventHandler(this.Frm_pagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_pagamento_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_pagamento;
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.TextBox tb_valorRecebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_troco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_aReceber;
    }
}