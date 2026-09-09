using System;
using DonPdv.pdv.connect;
using DonPdv.pdv.model;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DonPdv.pdv.dao
{
    class ClienteDAO
    {
        // Variavel de conex]ao
        //private readonly MySqlConnection vcon;
        private SQLiteConnection vcon;

        //Construtor
        public ClienteDAO()
        {
            this.vcon = new SQLiteConnection(ConnectionFactory.GetConnection());

        }
        public bool ExisteCliente(string cliente)
        {
            bool res;

            DataTable dt = new DataTable();
            string sql = "SELECT nome FROM tb_cliente WHERE nome = @nome";
            //MySqlCommand cmd = new MySqlCommand(sql, vcon);
            SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@nome", cliente);
            vcon.Open();
            cmd.ExecuteNonQuery();
            //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
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

        public void CriarCliente(Cliente obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_cliente (nome, telefone)
                    VALUES(@nome, @telefone)";
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar usuário: " + ex);
            }

        }
        public DataTable ListarClientes()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_cliente";
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

                MessageBox.Show("Erro ao listar clientes: " + ex);
                return null;
            }
        }
    }
}
