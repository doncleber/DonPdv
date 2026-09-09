using DonPdv.pdv.connect;
using DonPdv.pdv.model;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv.pdv.dao
{
   public class FornecedorDAO
    {
        // Variavel de conex]ao
        private SQLiteConnection vcon;

        //Construtor
        public FornecedorDAO()
        {
            this.vcon = new SQLiteConnection(ConnectionFactory.GetConnection());
        }
        public bool ExisteFornecedor(string nome)
        {
            bool res;

            DataTable dt = new DataTable();
            string sql = "SELECT nome FROM tb_fornecedor WHERE nome = @nome";
            SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@nome", nome);
            vcon.Open();
            cmd.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            vcon.Close();
            //vcon.Dispose();
            //vcon.ClearAllPoolsAsync();
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

        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_fornecedor(nome, telefone, endereco) VALUES(@nome, @telefone, @endereco)";
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor adicionado com sucesso!", "Dados inseridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                //vcon.Dispose();
               // vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar fornecedor: "+ ex);
            }
        }

        public void EditarFornecedor(Fornecedor obj, string id)
        {
            try
            {
                string sql = @"UPDATE tb_fornecedor SET nome = @nome, telefone = @telefone, endereco = @endereco WHERE id_fornecedor = @id";
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Editado com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                //vcon.Dispose();
                //con.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" +
                    " fornecedor: " + ex);
            }
        }

        public void ExcluirFornecedor(int id)
        {
            try
            {
                string sql = "DELETE FROM tb_fornecedor WHERE id_fornecedor= @id";
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído com sucesso!!", "Sucesso ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir fornecedor: " + ex);
            }
        }

        public DataTable ListarFornecedor()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_fornecedor";
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
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

                MessageBox.Show("Erro ao listar Fornecedores: " + ex);
                return null;
            }
        }
    }
}
