using DonPdv.pdv.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv.pdv.view
{
    public partial class frm_login : Form
    {
        readonly Frm_menuprincipal form1;
        public frm_login(Frm_menuprincipal f)
        {
            InitializeComponent();
            form1 = f;
        }

        //Código para criar objeto e função de fechar a aplicação
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr whnd, int wMsg , int wParam, int lParam);

        private void Panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Logar()
        {
            string user; string senha;
            user = tb_username.Text;
            senha = tb_senha.Text;
            // Verifica username vazio
            if(user == "")
            {
                MessageBox.Show("Username não pode ser vázio!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_username.Focus();
                return;
            }
            if (senha == "")
            {
                MessageBox.Show("Senha não pode ser vázio!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_senha.Focus();
                return;
            }
            UsuarioDAO dao = new UsuarioDAO();
            DataTable dt = dao.EfetuarLogin(user, senha);
            if(dt.Rows.Count == 1)
            {
                //form1.lb_usuario.Text = dt.Rows[0].ItemArray[1].ToString();
                form1.lb_usuario.Text = dt.Rows[0].Field<string>("nome");

                Program.nivel = int.Parse(dt.Rows[0].ItemArray[5].ToString());
                Program.nomeUsuario = dt.Rows[0].Field<string>("nome");
                Program.logado = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha errado!", "Tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_entrar_Click(object sender, EventArgs e)
        {
            Logar();
        }

     
    }
}
