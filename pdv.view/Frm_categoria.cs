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
    public partial class Frm_categoria : Form
    {
        string idSelecionado;
        public Frm_categoria()
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
            CategoriaDAO dao = new CategoriaDAO();
            Grid.DataSource = dao.ListarCategorias();

            //FormatarDG();
        }
        private void LimparCampos()
        {
            tb_nome.Text = String.Empty;

        }
        private void HabilitarCampos()
        {
            //Botões
            btn_salvar.Enabled = true;

            //Campos de preenchimentos
            tb_nome.Enabled = true;
           

        }
        private void DesabilitarCampos()
        {
            //Botões
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;

            //Campos de preenchimentos
            tb_nome.Enabled = false;
          
        }
        private void Frm_categoria_Load(object sender, EventArgs e)
        {
            CategoriaDAO dao = new CategoriaDAO();
            Grid.DataSource = dao.ListarCategorias();
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
            
            else
            {
                Categoria obj = new Categoria
                {
                    Nome = tb_nome.Text,
                    
                };

                CategoriaDAO dao = new CategoriaDAO();
                if (dao.ExisteCategoria(obj.Nome))
                {
                    MessageBox.Show("Categoria já existe!!", "Categoria existente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_nome.Focus();
                    return;
                }
                else
                {

                    dao.CadastrarCategoria(obj);
                    LimparCampos();
                    Listar();
                    tabCategoria.SelectedTab = tabPage1;
                }

            }
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
           
            else
            {
                Categoria obj = new Categoria
                {
                    Nome = tb_nome.Text,
                   
                };

                CategoriaDAO dao = new CategoriaDAO();
                dao.EditarCategoria(obj, idSelecionado);
                LimparCampos();
                Grid.DataSource = dao.ListarCategorias();
                tabCategoria.SelectedTab = tabPage1;


            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tabCategoria.SelectedTab = tabPage1;
            LimparCampos();
            DesabilitarCampos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = true;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;

            tabCategoria.SelectedTab = tabPage2;
            LimparCampos();
            HabilitarCampos();
            tb_nome.Focus();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSelecionado = Grid.CurrentRow.Cells[0].Value.ToString();
            tb_nome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            tabCategoria.SelectedTab = tabPage2;
            HabilitarCampos();
            //Botões
            btn_salvar.Enabled = false;
            btn_editar.Enabled = true;
            btn_excluir.Enabled = false;
            btn_editar.Text = "Salvar";
            //Recebe o usuario cadastrado no bd
            //fornecedorAntigo = Grid.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
