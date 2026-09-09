namespace DonPdv.pdv.view
{
    partial class Frm_consultaVenda
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
            this.dataGridViewVenda = new System.Windows.Forms.DataGridView();
            this.Grid_carrinho = new System.Windows.Forms.DataGridView();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabVenda = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_carrinho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabVenda.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVenda
            // 
            this.dataGridViewVenda.AllowUserToAddRows = false;
            this.dataGridViewVenda.AllowUserToDeleteRows = false;
            this.dataGridViewVenda.AllowUserToResizeColumns = false;
            this.dataGridViewVenda.AllowUserToResizeRows = false;
            this.dataGridViewVenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVenda.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVenda.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVenda.Location = new System.Drawing.Point(0, 13);
            this.dataGridViewVenda.Name = "dataGridViewVenda";
            this.dataGridViewVenda.ReadOnly = true;
            this.dataGridViewVenda.RowHeadersVisible = false;
            this.dataGridViewVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVenda.Size = new System.Drawing.Size(323, 200);
            this.dataGridViewVenda.TabIndex = 18;
            this.dataGridViewVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVenda_CellDoubleClick);
            // 
            // Grid_carrinho
            // 
            this.Grid_carrinho.AllowUserToAddRows = false;
            this.Grid_carrinho.AllowUserToDeleteRows = false;
            this.Grid_carrinho.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Grid_carrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_carrinho.BackgroundColor = System.Drawing.Color.White;
            this.Grid_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_carrinho.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_carrinho.Location = new System.Drawing.Point(325, 13);
            this.Grid_carrinho.Name = "Grid_carrinho";
            this.Grid_carrinho.ReadOnly = true;
            this.Grid_carrinho.RowHeadersVisible = false;
            this.Grid_carrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_carrinho.Size = new System.Drawing.Size(323, 200);
            this.Grid_carrinho.TabIndex = 17;
            this.Grid_carrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_carrinho_CellContentClick);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_imprimir.BackColor = System.Drawing.Color.Black;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.Gold;
            this.btn_imprimir.Location = new System.Drawing.Point(251, 306);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(158, 29);
            this.btn_imprimir.TabIndex = 13;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.lb_total);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(229, 237);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(657, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "---";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage_1);
            // 
            // tabVenda
            // 
            this.tabVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabVenda.Controls.Add(this.tabPage1);
            this.tabVenda.Controls.Add(this.tabPage2);
            this.tabVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVenda.Location = new System.Drawing.Point(5, 4);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.SelectedIndex = 0;
            this.tabVenda.Size = new System.Drawing.Size(665, 385);
            this.tabVenda.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewVenda);
            this.tabPage1.Controls.Add(this.Grid_carrinho);
            this.tabPage1.Controls.Add(this.btn_imprimir);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Relatório";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Frm_consultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 402);
            this.Controls.Add(this.tabVenda);
            this.Name = "Frm_consultaVenda";
            this.Text = "Consulta Vendas";
            this.Load += new System.EventHandler(this.Frm_consultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_carrinho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabVenda.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVenda;
        private System.Windows.Forms.DataGridView Grid_carrinho;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TabControl tabVenda;
        private System.Windows.Forms.TabPage tabPage1;
    }
}