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
    class CategoriaDAO
    {
        // Variavel de conex]ao
        //private readonly MySqlConnection vcon;
        private SQLiteConnection vcon;

        //Construtor
        public CategoriaDAO()
        {
            this.vcon = new SQLiteConnection(ConnectionFactory.GetConnection());

        }

        public DataTable ListarCategorias()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_categoria";
                //SQLiteCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
                
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
        public void CadastrarCategoria(Categoria obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_categoria(categoria) VALUES(@nome)";
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria adicionada com sucesso!", "Dados inseridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
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
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria editada com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar" +
                    " Categoria: " + ex);
            }
        }
    }
}
