using DonPdv.pdv.connect;
using DonPdv.pdv.model;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace DonPdv.pdv.dao
{
    class ItensVendaDAO
    {
        // Variavel de conex]ao
        private SQLiteConnection vcon;
        public ItensVendaDAO()
        {
            this.vcon = new SQLiteConnection(ConnectionFactory.GetConnection());
        }
        public void CadastrarItensVenda(ItensVenda item)
        {
            try
            {
                string sql = "INSERT INTO tb_itens_venda (fk_id_venda, fk_id_produto, valor, qtd, subtotal ) VALUES(@fk_id_venda, @fk_id_produto, @valor, @qtd, @subtotal)";
                //MySqlCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@fk_id_venda", item.IdVenda);
                cmd.Parameters.AddWithValue("@fk_id_produto", item.IdProduto);
                cmd.Parameters.AddWithValue("@valor", item.Valor);
                cmd.Parameters.AddWithValue("@qtd", item.Qtd);
                cmd.Parameters.AddWithValue("@subtotal", item.Qtd * item.Valor);
                vcon.Open();
                cmd.ExecuteNonQuery();
              //  MessageBox.Show("Itens inseridos com sucesso!!", "Itens cadastrados!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar Itens!!" + ex, "Erro nos Itens!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void VendaProduto(int qtdVenda, int id)
        {
            try
            {
                string sql = @"UPDATE tb_produto SET estoque = estoque - @qtdVenda WHERE id_produto = @id";
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@qtdVenda", qtdVenda);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Produto vendido com sucesso!!", "Produto vendido!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao baixar produto no estoque: " + ex);
            }
        }
        public DataTable ConsultarItensVendidos(int id_venda)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT         
                                tbp.nome as Produto,
                                tbi.valor as Valor,
                                tbi.qtd as Qtd,
                                tbi.subtotal as Subtotal
                              FROM tb_itens_venda as tbi   
                              inner join tb_produto as tbp on tbi.fk_id_produto = tbp.id_produto
                              WHERE fk_id_venda = @id_venda";
                           
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id_venda", id_venda);
                vcon.Open();
                cmd.ExecuteNonQuery();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Produtos para o carrinho: " + ex);
                return null;
            }
        }
    }
}
