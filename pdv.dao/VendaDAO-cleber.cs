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
    class VendaDAO
    {
        int row;
        // Variavel de conex]ao
        private readonly MySqlConnection vcon;
        public VendaDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }
        public void CadastrarVenda(Venda obj)
        {
            try
            {
                string sql = "INSERT INTO tb_venda (fk_id_cliente, total, data) VALUES(@cliente, @total, now())";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@cliente", 1);
                //cmd.Parameters.AddWithValue("@valor", obj.Valor);
                //cmd.Parameters.AddWithValue("@qtd", obj.Qtd);
                cmd.Parameters.AddWithValue("@total", obj.Total);
                //cmd.Parameters.AddWithValue("@fk_id_cliente", obj.Fk_id_cliente);
                vcon.Open();
                cmd.ExecuteNonQuery();
               //MessageBox.Show("Venda cadastrada com sucesso!!", "Venda cadastrada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();

                vcon.ClearAllPoolsAsync();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar venda!!" + ex, "Erro na venda!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public  int CodigoVendaAtual()
        {
            
            
            try
            {
                //DataTable row = new DataTable();
                string sql = "SELECT max(id_venda) FROM tb_venda";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();
               // cmd.ExecuteNonQuery();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    row = reader.GetInt32(0);
                    
                }

                
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();


                return row;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Codigo da venda: " + ex);
                return 0;
            }
            
        
       

        }


    }
}
