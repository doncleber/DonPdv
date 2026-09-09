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

namespace DonPdv.pdv.view
{
    public partial class Frm_fornecedor : Form
    {
        string idSelecionado;
        string fornecedorAntigo;
        public Frm_fornecedor()
        {
            InitializeComponent();
        }
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "TELEFONE";
            Grid.Columns[3].HeaderText = "ENDEREÇO";

            //DEFINE SE A COLUNA É VISIVEL
            Grid.Columns[0].Visible = false;

            //Tamanho da letra do header antes devemos colocar o VisualStyles como "FALSE"
            Grid.EnableHeadersVisualStyles = false;
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 19);
            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            Grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.AliceBlue;

            // O Header só fica centralizada se desabilitar a propriedade de ordenação
            Grid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Colocar valores centralizados na celula
            Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Define tamanho da coluna
            Grid.Columns[2].Width = 150;
        }
        private void Listar()
        {
            //Prenchendo o Data Grid View
            FornecedorDAO dao = new FornecedorDAO();
            Grid.DataSource = dao.ListarFornecedor();

            FormatarDG();
        }
        private void LimparCampos()
        {
            tb_nome.Text = tb_endereco.Text = mk_telefone.Text = String.Empty;
           
        }
        private void HabilitarCampos()
        {
            //Botões
            btn_salvar.Enabled = true;

            //Campos de preenchimentos
            tb_nome.Enabled = true;
            tb_endereco.Enabled = true;
            mk_telefone.Enabled = true;

        }
        private void DesabilitarCampos()
        {
            //Botões
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;

            //Campos de preenchimentos
            tb_nome.Enabled = false;
            tb_endereco.Enabled = false;
            mk_telefone.Enabled = false;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = true;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;

            tabFornecedor.SelectedTab = tabPage2;
            LimparCampos();
            HabilitarCampos();
            tb_nome.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tabFornecedor.SelectedTab = tabPage1;
            LimparCampos();
            DesabilitarCampos();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //Verificar se há campo vazio
            if (tb_nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo nome está vazio!!", "Campo nome vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
                return;
            }
            //Verificar se há campo vazio
            if (tb_endereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo endereço está vazio!!", "Campo endereço vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_endereco.Focus();
                return;
            }
            //Verificar se há campo vazio
            if (mk_telefone.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo telefone está vazio!!", "Campo telefone vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mk_telefone.Focus();
                return;
            }
            else
            {
                Fornecedor obj = new Fornecedor
                {
                    Nome = tb_nome.Text,
                    Endereco = tb_endereco.Text,
                    Telefone = mk_telefone.Text,
                };

                FornecedorDAO dao = new FornecedorDAO();
                if (dao.ExisteFornecedor(obj.Nome))
                {
                    MessageBox.Show("Fornecedor já existe!!", "Fornecedor existente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_nome.Focus();
                    return;
                }
                else
                {

                    dao.CadastrarFornecedor(obj);
                    LimparCampos();
                    tabFornecedor.SelectedTab = tabPage1;
                    Listar();
                }

            }
        }

        private void Frm_fornecedor_Load(object sender, EventArgs e)
        {
            Listar();
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
            if (mk_telefone.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo telefone está vazio!!", "Campo telefone vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mk_telefone.Focus();
                return;
            }
            if (tb_endereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo endereço está vazio!!", "Campo endereço vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_endereco.Focus();
                return;
            }
            else
            {
                Fornecedor obj = new Fornecedor
                {
                    Nome = tb_nome.Text,
                    Endereco = tb_endereco.Text,
                    Telefone = mk_telefone.Text
                   

                };

                FornecedorDAO dao = new FornecedorDAO();
                dao.EditarFornecedor(obj, idSelecionado);
                LimparCampos();
                Grid.DataSource = dao.ListarFornecedor();
                tabFornecedor.SelectedTab = tabPage1;
                Listar();
                

            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FornecedorDAO dao = new FornecedorDAO();
                dao.ExcluirFornecedor(int.Parse(idSelecionado.ToString()));
                //Grid.Rows.Remove(Grid.CurrentRow);

            }
            DesabilitarCampos();
            LimparCampos();
            tabFornecedor.SelectedTab = tabPage1;
            Listar();
        }


        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            tb_nome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            tb_endereco.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            mk_telefone.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            tabFornecedor.SelectedTab = tabPage2;
            HabilitarCampos();
            //Botões
            btn_salvar.Enabled = false;
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_editar.Text = "Salvar";
            //Recebe o usuario cadastrado no bd
            fornecedorAntigo = Grid.CurrentRow.Cells[2].Value.ToString();

        }
    }
    
}
