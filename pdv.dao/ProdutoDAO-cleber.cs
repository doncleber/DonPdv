using DonPdv.pdv.connect;
using DonPdv.pdv.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv.pdv.dao
{
  public  class ProdutoDAO
    {
        private readonly MySqlConnection vcon;

        public ProdutoDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }
        public bool ExisteProduto(string nome)
        {
            bool res;

            DataTable dt = new DataTable();
            string sql = "SELECT nome FROM tb_produto WHERE nome = @nome";
            MySqlCommand cmd = new MySqlCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@nome", nome);
            vcon.Open();
            cmd.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            vcon.Close();
            vcon.Dispose();
            vcon.ClearAllPoolsAsync();
            if (dt.Rows.Count > 0)
            {

                res = true;
            }
            else
            {
                res = false;
            }

            return res;



        }

        public void CadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_produto(nome, estoque, descricao, valor_venda, data, fk_id_fornecedor, fk_id_categoria) 
                                                VALUES(@nome, @estoque, @descricao, @valor_venda, curDate(), @fk_id_fornecedor, @fk_id_categoria)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@valor_venda", obj.ValorVenda);
                cmd.Parameters.AddWithValue("@fk_id_fornecedor", obj.FornecedorId);
                cmd.Parameters.AddWithValue("@fk_id_categoria", obj.CategoriaId);
                cmd.Parameters.AddWithValue("@estoque", obj.Estoque);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto adicionado com sucesso!", "Produto inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar produto: " + ex);
            }
        }
        
        public void EditarProduto(Produto obj, string id)
        {
            try
            {
                string sql = @"UPDATE tb_produto SET nome = @nome, descricao = @descricao,
                                fk_id_fornecedor = @fk_id_fornecedor, valor_venda = @valor_venda, estoque = @estoque WHERE id_produto = @id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@fk_id_fornecedor", obj.FornecedorId);
                cmd.Parameters.AddWithValue("@valor_venda", obj.ValorVenda);
                cmd.Parameters.AddWithValue("@estoque", obj.Estoque);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto atualizado com sucesso!!", "Produto atualizado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar produto: " + ex);
            }
        }
        public void ExcluirProduto(string id)
        {
            try
            {
                string sql = @"DELETE FROM tb_produto WHERE id_produto = @id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluído com sucesso!!", "Produto excluído!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir produto: " + ex);
            }
        }
        public DataTable ListarProduto()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT tbp.id_produto,
	                            tbp.nome,
	                            tbp.descricao,
	                            tbf.nome,
	                            tbp.estoque,
	                            tbp.valor_venda,
	                            tbp.valor_compra,
	                            tbp.data,
	                            tbp.fk_id_fornecedor
                            FROM tb_produto as tbp
                            INNER JOIN tb_fornecedor as tbf ON tbf.id_fornecedor = tbp.fk_id_fornecedor
                            ORDER BY tbp.nome";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Produto: " + ex);
                return null;
            }
        }
        public DataTable ListarProdutoPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT tbp.id_produto,
	                            tbp.nome,
	                            tbp.descricao,
	                            tbf.nome,
	                            tbp.estoque,
	                            tbp.valor_venda,
	                            tbp.valor_compra,
	                            tbp.fk_id_fornecedor
                            FROM tb_produto as tbp
                            INNER JOIN tb_fornecedor as tbf ON tbf.id_fornecedor = tbp.fk_id_fornecedor
                            WHERE tbp.nome like @nome
                            ORDER BY tbp.nome";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", nome);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Produto: " + ex);
                return null;
            }
        }
        public DataTable ListarProdutoParaVenda()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT tbp.id_produto,
	                            tbp.nome,
	                            tbp.descricao,
	                            tbf.nome,
	                            tbp.estoque,
	                            tbp.valor_venda,	                            
	                            tbp.fk_id_fornecedor
                            FROM tb_produto as tbp
                            INNER JOIN tb_fornecedor as tbf ON tbf.id_fornecedor = tbp.fk_id_fornecedor
                            ORDER BY tbp.nome";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Produto: " + ex);
                return null;
            }
        }
        
    }
}
