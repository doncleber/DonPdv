using DonPdv.pdv.connect;
using DonPdv.pdv.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv.pdv.dao
{
    class ItensVendaDAO
    {
        // Variavel de conex]ao
        private readonly MySqlConnection vcon;
        public ItensVendaDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }
        public void CadastrarItensVenda(ItensVenda item)
        {
            try
            {
                string sql = "INSERT INTO tb_itens_venda (fk_id_venda, fk_id_produto, valor, qtd) VALUES(@fk_id_venda, @fk_id_produto, @valor, @qtd)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@fk_id_venda", item.IdVenda);
                cmd.Parameters.AddWithValue("@fk_id_produto", item.IdProduto);
                cmd.Parameters.AddWithValue("@valor", item.Valor);
                cmd.Parameters.AddWithValue("@qtd", item.Qtd);
                vcon.Open();
                cmd.ExecuteNonQuery();
              //  MessageBox.Show("Itens inseridos com sucesso!!", "Itens cadastrados!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
                

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
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@qtdVenda", qtdVenda);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Produto vendido com sucesso!!", "Produto vendido!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao baixar produto no estoque: " + ex);
            }
        }
    }
}
