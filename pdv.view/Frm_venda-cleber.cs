using DonPdv.pdv.dao;
using DonPdv.pdv.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv.pdv.view
{
    /*   public class ImprimeVendaVista : PrintDocument
       {
           private Font bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
           private Font regular = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
           private Font relugarItens = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);

           public ImprimeVendaVista()
           {
               this.PrinterSettings.PrinterName = DefaultPrinter.GetDefaultPrinterName();
               this.OriginAtMargins = false;
               this.PrintPage += new PrintPageEventHandler(object, printDocument1_PrintPage);
           }
       }*/
    public partial class Frm_venda : Form
    {
    private Font bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
    private Font regular = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
    private Font relugarItens = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
        //Variaveis
        int qtd, estoque, codigoProd, vendaAtual;
        decimal preco;
        decimal subtotal, total;

        
        List<ItensVenda> itensLista = new List<ItensVenda>();




        //Carrinho
        DataTable carrinho = new DataTable();
        public Frm_venda()
        {
            InitializeComponent();
            lb_codigo.Visible = false;
            lb_data.Visible = false;
            lb_total.Text = "0,00";

            carrinho.Columns.Add("Codigo", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preco", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            Grid_carrinho.DataSource = carrinho;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabVenda.SelectedTab = tabPage2;
            Listar();
            
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "NOME";
            Grid.Columns[2].HeaderText = "DESCRIÇÃO";
            Grid.Columns[3].HeaderText = "FORNECEDOR";
            Grid.Columns[4].HeaderText = "ESTOQUE";
            Grid.Columns[5].HeaderText = "VENDA";
            //Grid.Columns[6].HeaderText = "COMPRA";
            //Grid.Columns[7].HeaderText = "DATA";
            Grid.Columns[6].HeaderText = "ID_FORNECEDOR";

            //DEFINE SE A COLUNA É VISIVEL
            Grid.Columns[0].Visible = false;
            Grid.Columns[6].Visible = false;

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
        private void Limpar()
        {
            lb_produto.Text = lb_estoque.Text = lb_valor.Text = string.Empty;
            tb_qtd.Text = txtPesquisar.Text = string.Empty;

        }
        private void Listar()
        {
            ProdutoDAO dao = new ProdutoDAO();
            Grid.DataSource = dao.ListarProdutoParaVenda();
            FormatarDG();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            tabVenda.SelectedTab = tabPage1;
        }


        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_codigo.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            lb_produto.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            lb_estoque.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            lb_valor.Text = Grid.CurrentRow.Cells[5].Value.ToString();

            tabVenda.SelectedTab = tabPage1;

            tb_qtd.Focus();
            tb_qtd.Text = "1";

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            graphics.DrawString("Pedido: " + vendaAtual , regular, Brushes.Black, 20, 95);
            graphics.DrawLine(Pens.Black, 20, 110, 310, 110);

            //Print Header
            graphics.DrawString("PRODUTO", regular, Brushes.Black, 20, 120);
            graphics.DrawString("QTD", regular, Brushes.Black, 130, 120); //150
            graphics.DrawString("VALOR", regular, Brushes.Black, 180, 120);
            graphics.DrawString("SUBTOTAL", regular, Brushes.Black, 225, 120);


           
            foreach (ItensVenda item in itensLista)
            {
                graphics.DrawString(item.ProdNome , relugarItens, Brushes.Black, 20, offset);
                graphics.DrawString(item.Qtd.ToString() , relugarItens, Brushes.Black, 135, offset);
                graphics.DrawString(item.Valor.ToString("C") , relugarItens, Brushes.Black, 180, offset);
                graphics.DrawString(item.Subtotal.ToString("C") , relugarItens, Brushes.Black, 235, offset);
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
            graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), relugarItens, Brushes.Black, 20, offset);
            graphics.DrawString("Hora: " + DateTime.Now.ToString("HH:mm:ss"), relugarItens, Brushes.Black, 220, offset);
            e.HasMorePages = false;
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void Frm_venda_Load(object sender, EventArgs e)
        {

        }

        private void btn_pagamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grid_carrinho.Rows.Count > 0)
                {


                    Venda obj = new Venda
                    {
                        // Codigo = int.Parse(Grid_carrinho.CurrentRow.Cells[0].Value.ToString()),
                        //Valor = decimal.Parse(Grid_carrinho.CurrentRow.Cells[3].Value.ToString()),
                        //  Qtd = int.Parse(Grid_carrinho.CurrentRow.Cells[2].Value.ToString()),
                        Total = decimal.Parse(lb_total.Text),
                        Pagamento = "Pix"
                    };

                    VendaDAO dao = new VendaDAO();
                    dao.CadastrarVenda(obj);
                    // tb_idVenda.Text = dao.CodigoVendaAtual().ToString();
                    vendaAtual = dao.CodigoVendaAtual();




                    foreach (DataGridViewRow dataGridViewRow in Grid_carrinho.Rows)
                    {
                        itensLista.Add(
                            new ItensVenda(int.Parse(dao.CodigoVendaAtual().ToString()),
                            int.Parse(dataGridViewRow.Cells[0].Value.ToString()),
                            int.Parse(dataGridViewRow.Cells[2].Value.ToString()),
                            decimal.Parse(dataGridViewRow.Cells[3].Value.ToString()),
                            decimal.Parse(dataGridViewRow.Cells[4].Value.ToString()),
                            dataGridViewRow.Cells[1].Value.ToString()

                            ));
                    }




                    ItensVendaDAO dal = new ItensVendaDAO();
                    foreach (ItensVenda item in itensLista)
                    {
                        //int estoq = estoque - item.Qtd;
                        //  MessageBox.Show("IdVenda: " + item.IdVenda + " " + "IdProduto: " + item.IdProduto + " " + "Qtd: " + item.Qtd + " " + "Valor: " + item.Valor);
                        dal.CadastrarItensVenda(item);
                        dal.VendaProduto(item.Qtd, item.IdProduto);
                        //estoq = 0;
                    }
                    carrinho.Clear();
                    printDocument1.Print();
                    total -= total;
                    lb_total.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("O carrinho não pode estar vazio!", "Carrinho vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            catch (Exception)
            {

                throw;
            }

            itensLista.Clear();
            

        }

    

            

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(tb_qtd.Text);
                preco = decimal.Parse(lb_valor.Text);

               
                

                estoque = int.Parse(lb_estoque.Text);
                codigoProd = int.Parse(lb_codigo.Text);

                if (estoque >= qtd)
                {
                    subtotal = qtd * preco;
                    total += subtotal;
                    //Adiciona ao carrinho
                    carrinho.Rows.Add(codigoProd, lb_produto.Text, qtd, preco, subtotal);

                    //Valor total
                    lb_total.Text = total.ToString();
                    Limpar();

                }
                else
                {
                    //qtd = 0;
                    MessageBox.Show("Estoque é menor que a quantidade solicitada!", "Estoque insuficiente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_qtd.Focus();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Quantidade vazia ou produto não informado", "Erro ao adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (Grid_carrinho.RowCount != 0)
            {
                decimal subproduto = decimal.Parse(Grid_carrinho.CurrentRow.Cells[4].Value.ToString());

                int indice = Grid_carrinho.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];
                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();

                total -= subproduto;

                //Valor total
                lb_total.Text = total.ToString();
                MessageBox.Show("Item removido!!", "Produto removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover!", "Nenhum produto selecionado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
