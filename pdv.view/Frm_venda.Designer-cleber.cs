namespace DonPdv.pdv.view
{
    partial class Frm_venda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabVenda = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_idVenda = new System.Windows.Forms.TextBox();
            this.lb_idVenda = new System.Windows.Forms.Label();
            this.Grid_carrinho = new System.Windows.Forms.DataGridView();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.btn_pagamento = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_qtd = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_estoque = new System.Windows.Forms.Label();
            this.lb_produto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.tabVenda.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_carrinho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVenda
            // 
            this.tabVenda.Controls.Add(this.tabPage1);
            this.tabVenda.Controls.Add(this.tabPage2);
            this.tabVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVenda.Location = new System.Drawing.Point(6, 6);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.SelectedIndex = 0;
            this.tabVenda.Size = new System.Drawing.Size(665, 385);
            this.tabVenda.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_idVenda);
            this.tabPage1.Controls.Add(this.lb_idVenda);
            this.tabPage1.Controls.Add(this.Grid_carrinho);
            this.tabPage1.Controls.Add(this.lb_data);
            this.tabPage1.Controls.Add(this.lb_codigo);
            this.tabPage1.Controls.Add(this.btn_pagamento);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_idVenda
            // 
            this.tb_idVenda.Location = new System.Drawing.Point(156, 250);
            this.tb_idVenda.Name = "tb_idVenda";
            this.tb_idVenda.Size = new System.Drawing.Size(100, 21);
            this.tb_idVenda.TabIndex = 19;
            // 
            // lb_idVenda
            // 
            this.lb_idVenda.AutoSize = true;
            this.lb_idVenda.Location = new System.Drawing.Point(85, 256);
            this.lb_idVenda.Name = "lb_idVenda";
            this.lb_idVenda.Size = new System.Drawing.Size(52, 15);
            this.lb_idVenda.TabIndex = 18;
            this.lb_idVenda.Text = "IdVenda";
            // 
            // Grid_carrinho
            // 
            this.Grid_carrinho.AllowUserToAddRows = false;
            this.Grid_carrinho.AllowUserToDeleteRows = false;
            this.Grid_carrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_carrinho.BackgroundColor = System.Drawing.Color.White;
            this.Grid_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_carrinho.DefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_carrinho.Location = new System.Drawing.Point(325, 13);
            this.Grid_carrinho.Name = "Grid_carrinho";
            this.Grid_carrinho.ReadOnly = true;
            this.Grid_carrinho.RowHeadersVisible = false;
            this.Grid_carrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_carrinho.Size = new System.Drawing.Size(323, 200);
            this.Grid_carrinho.TabIndex = 17;
            // 
            // lb_data
            // 
            this.lb_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_data.Location = new System.Drawing.Point(321, 287);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(49, 20);
            this.lb_data.TabIndex = 16;
            // 
            // lb_codigo
            // 
            this.lb_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_codigo.Location = new System.Drawing.Point(321, 256);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(49, 20);
            this.lb_codigo.TabIndex = 15;
            // 
            // btn_pagamento
            // 
            this.btn_pagamento.BackColor = System.Drawing.Color.Black;
            this.btn_pagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagamento.FlatAppearance.BorderSize = 0;
            this.btn_pagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagamento.ForeColor = System.Drawing.Color.Gold;
            this.btn_pagamento.Location = new System.Drawing.Point(454, 301);
            this.btn_pagamento.Name = "btn_pagamento";
            this.btn_pagamento.Size = new System.Drawing.Size(158, 29);
            this.btn_pagamento.TabIndex = 13;
            this.btn_pagamento.Text = "Pagamento";
            this.btn_pagamento.UseVisualStyleBackColor = false;
            this.btn_pagamento.Click += new System.EventHandler(this.btn_pagamento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_total);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(428, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 63);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // lb_total
            // 
            this.lb_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_total.Location = new System.Drawing.Point(96, 28);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(88, 20);
            this.lb_total.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total (R$).:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_qtd);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btn_remover);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.lb_valor);
            this.groupBox1.Controls.Add(this.lb_estoque);
            this.groupBox1.Controls.Add(this.lb_produto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 207);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // tb_qtd
            // 
            this.tb_qtd.Location = new System.Drawing.Point(119, 111);
            this.tb_qtd.Name = "tb_qtd";
            this.tb_qtd.Size = new System.Drawing.Size(49, 21);
            this.tb_qtd.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::DonPdv.Properties.Resources.pesquisar_20;
            this.pictureBox2.Location = new System.Drawing.Point(256, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.Black;
            this.btn_remover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remover.FlatAppearance.BorderSize = 0;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.Color.Gold;
            this.btn_remover.Location = new System.Drawing.Point(169, 157);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(100, 29);
            this.btn_remover.TabIndex = 8;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Gold;
            this.btn_add.Location = new System.Drawing.Point(44, 157);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 29);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_valor
            // 
            this.lb_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_valor.Location = new System.Drawing.Point(193, 112);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(57, 20);
            this.lb_valor.TabIndex = 7;
            // 
            // lb_estoque
            // 
            this.lb_estoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_estoque.Location = new System.Drawing.Point(24, 112);
            this.lb_estoque.Name = "lb_estoque";
            this.lb_estoque.Size = new System.Drawing.Size(49, 20);
            this.lb_estoque.TabIndex = 5;
            // 
            // lb_produto
            // 
            this.lb_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_produto.Location = new System.Drawing.Point(79, 46);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(171, 20);
            this.lb_produto.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Valor (R$).:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(128, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Qtd.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Estoque.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Produto.:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.txtPesquisar);
            this.tabPage2.Controls.Add(this.Grid);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(657, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produtos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Black;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Gold;
            this.btn_cancelar.Location = new System.Drawing.Point(476, 17);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(77, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DonPdv.Properties.Resources.pesquisar_20;
            this.pictureBox1.Location = new System.Drawing.Point(415, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(137, 18);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(272, 22);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Location = new System.Drawing.Point(1, 50);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(655, 289);
            this.Grid.TabIndex = 6;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // Frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 402);
            this.Controls.Add(this.tabVenda);
            this.Name = "Frm_venda";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Frm_venda_Load);
            this.tabVenda.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_carrinho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVenda;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_pagamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_estoque;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox tb_qtd;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.DataGridView Grid_carrinho;
        private System.Windows.Forms.Label lb_idVenda;
        private System.Windows.Forms.TextBox tb_idVenda;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}