using DonPdv.pdv.connect;
using DonPdv.pdv.model;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DonPdv.pdv.dao
{
    class UsuarioDAO
    {
        // Variavel de conex]ao
        //private readonly MySqlConnection vcon;
        private SQLiteConnection vcon;

        //Construtor
        public UsuarioDAO()
        {
            this.vcon = new SQLiteConnection(ConnectionFactory.GetConnection());
            
        }

        public bool ExisteUsername(string username)
        {
            bool res;
            
                DataTable dt = new DataTable();
                string sql = "SELECT username FROM tb_user WHERE username = @username";
                //MySqlCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@username", username);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
                if(dt.Rows.Count > 0)
                {

                    res = true;
                }
                else
                {
                    res = false;
                }

                return res;

            
            
        }
        public DataTable EfetuarLogin(string username, string senha)
        {
            try
            {
                
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_user WHERE username = @username and senha = @senha";
                //MySqlCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@senha", senha);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao efetuar login: " + ex);
                return null;
            }
        }

        public void CastrarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_user (nome, username, senha, status, nivel) 
                                VALUES(@nome, @username, @senha, @status, @nivel)";
                //MySqlCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@username", obj.Username);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                cmd.Parameters.AddWithValue("@nivel", obj.Nivel);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Cadastrar usuário: " + ex);
            }
        }

        public DataTable ListarUsuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_user";
                //MySqlCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
                return dt
                    ;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar usuários: " + ex);
                return null;
            }
        }

        public void EditarUsuario(Usuario obj, int id)
        {

            try
            {
                string sql = @"UPDATE tb_user SET nome = @nome , username = @username, senha = @senha, status = @status, nivel = @nivel WHERE id_user = @id";
                //MySqlCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@username", obj.Username);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                cmd.Parameters.AddWithValue("@nivel", obj.Nivel);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao editar usuário: " + ex);
            }
        }
        public void ExcluirUsuario(int id)
        {
            try
            {
                string sql = "DELETE FROM tb_user WHERE id_user= @id";
                //MySqlCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário excluído com sucesso!!", "Sucesso ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir usuário: " + ex);
            }
        }
        public DataTable ListarUsuarioPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_user WHERE nome LIKE @nome";
                //MySqlCommand cmd = new MySqlCommand(sql, vcon);
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", nome);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                //vcon.Dispose();
                //vcon.ClearAllPoolsAsync();
                return dt;
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar usuarios por nome" + ex);
                return null;
            }
        }
    }
}
