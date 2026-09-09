using DonPdv.pdv.dao;
using DonPdv.pdv.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv
{
    public partial class Frm_usuario : Form
    {
        string id_user;
        string usuarioAntigo;
        public Frm_usuario()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tb_nome.Text = tb_username.Text = tb_senha.Text = String.Empty;
            cb_status.SelectedIndex = 0;
            nup_nivel.Value = 0;
        }
        private void HabilitarCampos()
        {
            //Botões
            btn_salvar.Enabled = true;

            //Campos de preenchimentos
            tb_nome.Enabled = true;
            tb_username.Enabled = true;
            tb_senha.Enabled = true;
            cb_status.Enabled = true;
            nup_nivel.Enabled = true;

        }
        private void DesabilitarCampos()
        {
            //Botões
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            
            //Campos de preenchimentos
            tb_nome.Enabled = false;
            tb_username.Enabled = false;
            tb_senha.Enabled = false;
            cb_status.Enabled = false;
            nup_nivel.Enabled = false;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = true;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;

            tabUsuario.SelectedTab = tabPage2;
            LimparCampos();
            HabilitarCampos();
            tb_nome.Focus();
        }

        private void Frm_usuario_Load(object sender, EventArgs e)
        {
            cb_status.SelectedIndex = 0;
            UsuarioDAO dao = new UsuarioDAO();
            Grid.DataSource = dao.ListarUsuarios();
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //Verificar se há campo vazio
            if ( tb_nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo nome está vazio!!","Campo nome vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
                return;
            }
            if (tb_username.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo username está vazio!!", "Campo username vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_username.Focus();
                return;
            }
            if (tb_senha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo senha está vazio!!", "Campo senha vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_senha.Focus();
                return;
            }
            else
            {
                Usuario obj = new Usuario
                {
                    Nome = tb_nome.Text,
                    Username = tb_username.Text,
                    Senha = tb_senha.Text,
                    Status = cb_status.Text,
                    Nivel = int.Parse( nup_nivel.Value.ToString())
                };

                UsuarioDAO dao = new UsuarioDAO();
                if (dao.ExisteUsername(obj.Username))
                {
                    MessageBox.Show("Username já existe!!", "Username existente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_username.Focus();
                    return;
                }
                else
                {

                dao.CastrarUsuario(obj);
                LimparCampos();
                }

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            tabUsuario.SelectedTab = tabPage1;
            LimparCampos();
            DesabilitarCampos();
        }

     
        private void btn_editar_Click(object sender, EventArgs e)
        {
            //Verificar se há campo vazio
            if (tb_nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo nome está vazio!!", "Campo nome vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
                return;
            }
            if (tb_username.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo username está vazio!!", "Campo username vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_username.Focus();
                return;
            }
            if (tb_senha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo senha está vazio!!", "Campo senha vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_senha.Focus();
                return;
            }
            else
            {
                Usuario obj = new Usuario
                {
                    Nome = tb_nome.Text,
                    Username = tb_username.Text,
                    Senha = tb_senha.Text,
                    Status = cb_status.Text,
                    Nivel = int.Parse(nup_nivel.Value.ToString())
                    
                };

                UsuarioDAO dao = new UsuarioDAO();
                if(tb_username.Text != usuarioAntigo)
                {
                    if (dao.ExisteUsername(tb_username.Text))
                    {
                        MessageBox.Show("O username que você tentou usar já pertence a outro usuário!", "Erro ao duplicar username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dao.EditarUsuario(obj, int.Parse(id_user.ToString()));
                        LimparCampos();
                        Grid.DataSource = dao.ListarUsuarios();
                        tabUsuario.SelectedTab = tabPage1;
                    }
                }
                else
                {

                dao.EditarUsuario(obj, int.Parse(id_user.ToString()));
                LimparCampos();
                Grid.DataSource = dao.ListarUsuarios();
                tabUsuario.SelectedTab = tabPage1;
                }

            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                UsuarioDAO dao = new UsuarioDAO();
                dao.ExcluirUsuario(int.Parse(id_user.ToString()));
                Grid.Rows.Remove(Grid.CurrentRow);
                    
            }
            DesabilitarCampos();
            LimparCampos();
            tabUsuario.SelectedTab = tabPage1;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_user = Grid.CurrentRow.Cells[0].Value.ToString();
            tb_nome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            tb_username.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            tb_senha.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            cb_status.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            nup_nivel.Text = Grid.CurrentRow.Cells[5].Value.ToString();
            tabUsuario.SelectedTab = tabPage2;
            HabilitarCampos();
            //Botões
            btn_salvar.Enabled = false;
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_editar.Text = "Salvar";
            //Recebe o usuario cadastrado no bd
            usuarioAntigo = Grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";
            UsuarioDAO dao = new UsuarioDAO();
            Grid.DataSource = dao.ListarUsuarioPorNome(nome);
        }
    }
}
