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
    class CategoriaDAO
    {
        // Variavel de conex]ao
        private readonly MySqlConnection vcon;

        //Construtor
        public CategoriaDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public DataTable ListarCategorias()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_categoria";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
                return dt
                    ;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar categorias: " + ex);
                return null;
            }
        }
        public bool ExisteCategoria(string nome)
        {
            bool res;

            DataTable dt = new DataTable();
            string sql = "SELECT categoria FROM tb_categoria WHERE categoria = @nome";
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
        public void CadastrarCategoria(Categoria obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_categoria(categoria) VALUES(@nome)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria adicionada com sucesso!", "Dados inseridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar Categoria: " + ex);
            }
        }
        public void EditarCategoria(Categoria obj, string id)
        {
            try
            {
                string sql = @"UPDATE tb_categoria SET categoria = @nome WHERE id_categoria = @id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria editada com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" +
                    " Categoria: " + ex);
            }
        }
        public void ExcluirCategoria(int id)
        {
            try
            {
                string sql = "DELETE FROM tb_categoria WHERE id_categoria= @id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria excluída com sucesso!!", "Sucesso ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir Categoria: " + ex);
            }
        }
    }
}
