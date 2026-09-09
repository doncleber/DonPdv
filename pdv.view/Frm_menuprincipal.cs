using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv.pdv.view
{
    public partial class Frm_menuprincipal : Form
    {
        // Variavel de ativação de formulário
        private Form activeForm;
        public Frm_menuprincipal()
        {
            InitializeComponent();
            frm_login login = new frm_login(this);
            login.ShowDialog();
        }
        //Metódo para chamar o active Form
        private void openChildForm(Form childForm, object btnSender)
        {
            //Se já existir outro formulário aberto o if o fechará pois não pode ter 2
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_desktop.Controls.Add(childForm);
            this.panel_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lb_title.Text = childForm.Text;
        }

        //Metodo para abrir formularios por nivel de acesso
        public void AbreForm(int nivel, Form f, object sender)
        {
            if (Program.logado)
            {
                if(Program.nivel >= nivel)
                {
                    openChildForm(f, sender);
                    
                }
                else
                {
                    MessageBox.Show("Acesso negado!", "Acesso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("É nessecário ter um usuário logado!", "Acesso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            Frm_usuario Form = new Frm_usuario();
            AbreForm(3, Form, sender);
        }

        private void Frm_menuprincipal_Load(object sender, EventArgs e)
        {
            //lb_data.Text = DateTime.Now.ToShortDateString();
           
            
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_categoria Form = new Frm_categoria();
            AbreForm(3, Form, sender);
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_fornecedor Form = new Frm_fornecedor();
            AbreForm(3, Form, sender);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_produto Form = new Frm_produto();
            AbreForm(3, Form, sender);
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            Frm_venda Form = new Frm_venda();
            AbreForm(1, Form, sender);
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_consultaVenda Form = new Frm_consultaVenda();
            AbreForm(1, Form, sender);
        }

        

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_cliente Form = new Frm_cliente();
            AbreForm(1, Form, sender);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_clienteConsulta Form = new Frm_clienteConsulta();
            AbreForm(1, Form, sender);
        }

      

        private void lb_hora_Click(object sender, EventArgs e)
        {

        }
    }
}
