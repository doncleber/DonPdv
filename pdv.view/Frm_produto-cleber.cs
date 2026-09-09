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
    public partial class Frm_produto : Form
    {
        string idSelecionado;
        string produtoAntigo;
        public Frm_produto()
        {
            InitializeComponent();
        }
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "DESCRIÇÃO";
            Grid.Columns[3].HeaderText = "FORNECEDOR";
            Grid.Columns[4].HeaderText = "ESTOQUE";
            Grid.Columns[5].HeaderText = "VENDA";
            Grid.Columns[6].HeaderText = "COMPRA";
            Grid.Columns[7].HeaderText = "DATA";
            Grid.Columns[8].HeaderText = "ID_FORNECEDOR";

            //DEFINE SE A COLUNA É VISIVEL
            Grid.Columns[0].Visible = false;
            Grid.Columns[8].Visible = false;

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

            //Formatar coluna para moeda

            Grid.Columns[5].DefaultCellStyle.Format = "C2";
            Grid.Columns[6].DefaultCellStyle.Format = "C2";

            // Define tamanho da coluna
            Grid.Columns[2].Width = 150;
        }
        private void Listar()
        {
            ProdutoDAO dao = new ProdutoDAO();
            Grid.DataSource = dao.ListarProduto();
            FormatarDG();
        }
        private void ComboFornecedor()
        {
            FornecedorDAO dao = new FornecedorDAO();
            cb_fornecedor.DataSource = dao.ListarFornecedor();
            //Display para mostrar o nome do fornecedor
            cb_fornecedor.DisplayMember = "nome";
            //Value para pegar o id que vem da tabela de fornecedor e mandá-lo para tabela de produto
            cb_fornecedor.ValueMember = "id_fornecedor";
        }
        private void ComboCategoria()
        {
            CategoriaDAO dao = new CategoriaDAO();
            cb_categoria.DataSource = dao.ListarCategorias();
            //Display para mostrar o nome da Categoria
            cb_categoria.DisplayMember = "categoria";
            //Value para pegar o id que vem da tabela de Categoria e mandá-lo para tabela de produto
            cb_categoria.ValueMember = "id_categoria";
        }
        private void LimparCampos()
        {
            tb_nome.Text = tb_descricao.Text = tb_estoque.Text = tb_venda.Text = string.Empty;
            cb_fornecedor.SelectedIndex = 0;

            if(Grid.DataSource is DataTable dt)
            {
                dt.Rows.Clear();
            }
        }
        private void HabilitarCampos()
        {
            tb_nome.Enabled = true;
            tb_descricao.Enabled = true;
            tb_estoque.Enabled = true;
            tb_venda.Enabled = true;
            cb_fornecedor.Enabled = true;
            cb_categoria.Enabled = true;
            tb_nome.Focus();

        }
        private void DesabilitarCampos()
        {
            //botões
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            //campos
            tb_nome.Enabled = false;
            tb_descricao.Enabled = false;
            tb_venda.Enabled = false;
            tb_estoque.Enabled = false;
            cb_fornecedor.Enabled = false;
        }
        private void Frm_produto_Load(object sender, EventArgs e)
        {
            ComboCategoria();
            ComboFornecedor();
            Listar();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_salvar.Enabled = true;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            LimparCampos();
            HabilitarCampos();
            tabProduto.SelectedTab = tabPage2;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
            tabProduto.SelectedTab = tabPage1;
            Listar();
            txtPesquisar.Focus();
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
            if (cb_fornecedor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo fornecedor está vazio!!", "Campo fornecedor vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_fornecedor.Focus();
                return;
            }
            //Verificar se há campo vazio
            if (tb_estoque.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo estoque está vazio!!", "Campo estoque vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_estoque.Focus();
                return;
            }
            if (tb_venda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo venda está vazio!!", "Campo venda vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_venda.Focus();
                return;
            }
            else
            {
                Produto obj = new Produto
                {
                    Nome = tb_nome.Text,
                    FornecedorId = int.Parse(cb_fornecedor.SelectedValue.ToString()),
                    CategoriaId = int.Parse(cb_categoria.SelectedValue.ToString()),
                    Estoque = int.Parse(tb_estoque.Text),
                    ValorVenda = decimal.Parse(tb_venda.Text),
                    Descricao = tb_descricao.Text
                    
                };

                ProdutoDAO dao = new ProdutoDAO();
                if (dao.ExisteProduto(obj.Nome))
                {
                    MessageBox.Show("Produto já existe!!", "Produto existente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_nome.Focus();
                    return;
                }
                else
                {

                    dao.CadastrarProduto(obj);
                    LimparCampos();
                    tabProduto.SelectedTab = tabPage1;
                    Listar();
                }

            }
        }

        private void Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            tb_nome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            tb_descricao.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            cb_fornecedor.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            tb_estoque.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            tb_venda.Text = Grid.CurrentRow.Cells[5].Value.ToString();
            produtoAntigo = Grid.CurrentRow.Cells[1].Value.ToString();
            tabProduto.SelectedTab = tabPage2;
            HabilitarCampos();
            //Botões
            btn_salvar.Enabled = false;
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_editar.Text = "Salvar";
            //Recebe o usuario cadastrado no bd
           // produtoAntigo = Grid.CurrentRow.Cells[2].Value.ToString();

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
            if (tb_venda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo venda está vazio!!", "Campo venda vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_venda.Focus();
                return;
            }
            if (tb_estoque.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo estoque está vazio!!", "Campo estoque vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_estoque.Focus();
                return;
            }
            else
            {
                Produto obj = new Produto
                {
                    Nome = tb_nome.Text,
                    Estoque = int.Parse( tb_estoque.Text),
                    ValorVenda = decimal.Parse(tb_venda.Text),
                    FornecedorId = int.Parse(cb_fornecedor.SelectedValue.ToString()),
                    Descricao = tb_descricao.Text


                };

                ProdutoDAO dao = new ProdutoDAO();
                dao.EditarProduto(obj, idSelecionado);
                LimparCampos();
                Grid.DataSource = dao.ListarProduto();
                tabProduto.SelectedTab = tabPage1;
                Listar();


            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a exclusão?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                ProdutoDAO dao = new ProdutoDAO();
                dao.ExcluirProduto(idSelecionado);
                //Grid.Rows.Remove(Grid.CurrentRow);
            }
            DesabilitarCampos();
            LimparCampos();
            tabProduto.SelectedTab = tabPage1;
            Listar();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();
            Grid.DataSource = dao.ListarProdutoPorNome(nome);
            FormatarDG();
        }
    }
}
