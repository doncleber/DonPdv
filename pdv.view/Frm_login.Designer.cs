namespace DonPdv.pdv.view
{
    partial class frm_login
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
            this.panel_title = new System.Windows.Forms.Panel();
            this.lb_cadastrarusuario = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_title.Controls.Add(this.lb_cadastrarusuario);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(362, 65);
            this.panel_title.TabIndex = 1;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_title_MouseDown);
            // 
            // lb_cadastrarusuario
            // 
            this.lb_cadastrarusuario.AutoSize = true;
            this.lb_cadastrarusuario.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastrarusuario.ForeColor = System.Drawing.Color.Gold;
            this.lb_cadastrarusuario.Location = new System.Drawing.Point(134, 18);
            this.lb_cadastrarusuario.Name = "lb_cadastrarusuario";
            this.lb_cadastrarusuario.Size = new System.Drawing.Size(56, 22);
            this.lb_cadastrarusuario.TabIndex = 1;
            this.lb_cadastrarusuario.Text = "Login";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_entrar.Location = new System.Drawing.Point(170, 201);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(96, 23);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.Btn_entrar_Click);
            // 
            // lb_usuario
            // 
            this.lb_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(50, 111);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(62, 17);
            this.lb_usuario.TabIndex = 3;
            this.lb_usuario.Text = "Usuário:";
            // 
            // tb_senha
            // 
            this.tb_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_senha.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(143, 154);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(156, 26);
            this.tb_senha.TabIndex = 2;
            // 
            // tb_username
            // 
            this.tb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_username.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(143, 102);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(156, 26);
            this.tb_username.TabIndex = 1;
            // 
            // lb_senha
            // 
            this.lb_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(62, 163);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(50, 17);
            this.lb_senha.TabIndex = 6;
            this.lb_senha.Text = "Senha:";
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sair.Location = new System.Drawing.Point(170, 242);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(96, 23);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 315);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.panel_title);
            this.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don Pdv - v 1.0";
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label lb_cadastrarusuario;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Button btn_sair;
    }
}