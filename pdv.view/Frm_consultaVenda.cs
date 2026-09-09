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
    public partial class Frm_consultaVenda : Form
    {
        private Font bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        private Font regular = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        private Font relugarItens = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);

        int vendaAtual;
        decimal total;
        string dataVenda, horaVenda;

        List<ItensVenda> itensLista = new List<ItensVenda>();
        List<Carrinho> itensCarrinho = new List<Carrinho>();
        DataTable vendas = new DataTable();

        public Frm_consultaVenda()
        {
            InitializeComponent();
            // lb_codigo.Visible = false;
            //lb_data.Visible = false;
            lb_total.Text = "0,00";

            //vendas.Columns.Add("Codigo", typeof(int));
            vendas.Columns.Add("Produto", typeof(string));
            vendas.Columns.Add("Qtd", typeof(string));
            vendas.Columns.Add("Valor", typeof(decimal));
            vendas.Columns.Add("Subtotal", typeof(decimal));
            //vendas.Columns.Add("Data", typeof(DateTime));


            Grid_carrinho.DataSource = vendas;
            Grid_carrinho.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //Grid_carrinho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //Grid_carrinho.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //Grid_carrinho.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //Grid_carrinho.Columns[0].Visible = false;
            //Grid_carrinho.Columns[5].Visible = false;
        }

        private void Frm_consultaVenda_Load(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();

            dataGridViewVenda.DataSource = dao.ConsultaVendas();
            //total = decimal.Parse(dataGridViewVenda.SelectedCells[1].Value.ToString());
            //vendas.Rows.Add(1, "Raimunda", "Dinheiro", 109.95, "2025/10/05");
            // vendas.Rows.Add();
        }

        private void DataGridViewVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ItensVendaDAO dao = new ItensVendaDAO();
            DataTable item = new DataTable();
            item = dao.ConsultarItensVendidos(int.Parse(dataGridViewVenda.SelectedCells[0].Value.ToString()));
            //item.Rows.Add(1, 1, 10, 20);
            //DataTable consulta = dao.ConsultarItensVendidos(int.Parse(dataGridViewVenda.SelectedCells[0].Value.ToString()));

            /*itensCarrinho.Add(
               new Carrinho(consulta.Columns[0].ToString(),
               int.Parse(consulta.Columns[1].ToString()),
               decimal.Parse(consulta.Columns[2].ToString()),
               decimal.Parse(consulta.Columns[3].ToString())));*/

            // vendas.Rows.Add(dao.ConsultarItensVendidos(int.Parse(dataGridViewVenda.SelectedCells[0].Value.ToString())));
            //vendas.Rows.Add(dataGridViewVenda.SelectedCells[0].Value.ToString());
            //int qtd = int.Parse(item.Rows[0][2].ToString());
            //decimal vlr = 0;
            List<Carrinho> itensCarrinho = new List<Carrinho>();


           /* foreach (DataTable i in item.Rows)
            {
               // itensCarrinho.Add(
               // new Carrinho(i.Rows[0][0].ToString(), int.Parse(i.Rows[0][2].ToString()), decimal.Parse(i.Rows[0][1].ToString()), decimal.Parse(i.Rows[0][1].ToString()) * int.Parse(item.Rows[0][2].ToString()))
              //  );



                //Grid_carrinho.DataSource = itensCarrinho;



            }*/
                Grid_carrinho.DataSource = dao.ConsultarItensVendidos(int.Parse(dataGridViewVenda.SelectedCells[0].Value.ToString()));
                lb_total.Text = dataGridViewVenda.SelectedCells[2].Value.ToString();
                vendaAtual = int.Parse(dataGridViewVenda.SelectedCells[0].Value.ToString());
        }
        

        private void PrintDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int offset = 140;


            //Print Header
            graphics.DrawString("Alegria e Vida Confecções LTDA", bold, Brushes.Black, 50, 10);
            graphics.DrawString("Rua Branca Nº 168", regular, Brushes.Black, 50, 27);
            graphics.DrawString("Conceição, Feira de Santana, BA", regular, Brushes.Black, 50, 40);
            graphics.DrawLine(Pens.Black, 20, 55, 310, 55);
            graphics.DrawString("CUPOM NÃO FISCAL", bold, Brushes.Black, 80, 60);
            graphics.DrawLine(Pens.Black, 20, 80, 310, 80);
            graphics.DrawString("Pedido: " + vendaAtual, regular, Brushes.Black, 20, 95);
            graphics.DrawLine(Pens.Black, 20, 110, 310, 110);

            //Print Header
            graphics.DrawString("PRODUTO", regular, Brushes.Black, 20, 120);
            graphics.DrawString("QTD", regular, Brushes.Black, 130, 120); //150
            graphics.DrawString("VALOR", regular, Brushes.Black, 180, 120);
            graphics.DrawString("SUBTOTAL", regular, Brushes.Black, 225, 120);



            foreach (ItensVenda item in itensLista)
            {
                graphics.DrawString(item.ProdNome, relugarItens, Brushes.Black, 20, offset);
                graphics.DrawString(item.Qtd.ToString(), relugarItens, Brushes.Black, 135, offset);
                graphics.DrawString(item.Valor.ToString("C"), relugarItens, Brushes.Black, 180, offset);
                graphics.DrawString(item.Subtotal.ToString("C"), relugarItens, Brushes.Black, 235, offset);
                offset += 20;

            }

            //TOTAL
            graphics.DrawLine(Pens.Black, 20, offset, 310, offset);
            offset += 5;

            graphics.DrawString("TOTAL R$: ", bold, Brushes.Black, 20, offset);
            graphics.DrawString(total.ToString("C"), relugarItens, Brushes.Black, 230, offset);
            offset += 15;

            graphics.DrawLine(Pens.Black, 20, offset, 310, offset);
            offset += 5;

            //BOTTOM
            graphics.DrawString("Data: " + dataVenda, relugarItens, Brushes.Black, 20, offset);
            graphics.DrawString("Hora: " + horaVenda, relugarItens, Brushes.Black, 220, offset);
            e.HasMorePages = false;
        }

        private void Grid_carrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            //var d = Grid_carrinho.SelectedCells[3].Value.ToString();

           // MessageBox.Show(d);
            //0 nome, 1 valor, 2 quantidade, 3 subtotal

            foreach (DataGridViewRow dataGridViewRow in Grid_carrinho.Rows)
            {
                //MessageBox.Show(dataGridViewRow.Cells[1].Value.ToString());// " 3 " + decimal.Parse(dataGridViewRow.Cells[2].Value.ToString()) + " " + decimal.Parse(dataGridViewRow.Cells[3].Value.ToString()) + "4" + dataGridViewRow.Cells[0].Value.ToString());
                itensLista.Add(
                    new ItensVenda(vendaAtual,//int.Parse(dao.CodigoVendaAtual().ToString()),
                    0,//int.Parse(dataGridViewRow.Cells[0].Value.ToString()),
                    int.Parse(dataGridViewRow.Cells[2].Value.ToString()),
                    decimal.Parse(dataGridViewRow.Cells[1].Value.ToString()),
                    decimal.Parse(dataGridViewRow.Cells[3].Value.ToString()),
                    dataGridViewRow.Cells[0].Value.ToString()

                    ));
            }
             var dataVendas = dataGridViewVenda.SelectedCells[4].Value.ToString();
            dataVenda = dataVendas.Substring(0, 10);
            horaVenda = dataVendas.Substring(11, 8);
            total = decimal.Parse(lb_total.Text);
            printDocument1.Print();
            itensLista.Clear();
            //MessageBox.Show(d1);
        }

    }
}
