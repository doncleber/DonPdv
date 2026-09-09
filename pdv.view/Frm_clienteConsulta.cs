using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonPdv.pdv.dao;
using DonPdv.pdv.model;

namespace DonPdv.pdv.view
{
    public partial class Frm_clienteConsulta : Form
    {
        public Frm_clienteConsulta()
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
            ClienteDAO dao = new ClienteDAO();
            Grid.DataSource = dao.ListarClientes();
        }
        private void Frm_clienteConsulta_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
