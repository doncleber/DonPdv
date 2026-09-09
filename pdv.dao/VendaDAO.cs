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
    class VendaDAO
    {
        int row;
        // Variavel de conex]ao
        private SQLiteConnection vcon;
        public VendaDAO()
        {
            this.vcon = new SQLiteConnection(ConnectionFactory.GetConnection());
        }
        public void CadastrarVenda(Venda obj)
        {
            try
            {
                string sql = "INSERT INTO tb_venda (fk_id_cliente, total, pagamento, vl_recebido, troco, data) VALUES(@cliente, @total, @pagamento, @vl_recebido, @troco, datetime('now', 'localtime'))";
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@cliente", 1);
                //cmd.Parameters.AddWithValue("@valor", obj.Valor);
                // cmd.Parameters.AddWithValue("@qtd", obj.Qtd);
                cmd.Parameters.AddWithValue("@total", obj.Total);
                cmd.Parameters.AddWithValue("@pagamento", obj.Pagamento);
                cmd.Parameters.AddWithValue("@vl_recebido", obj.ValorRecebido);
                cmd.Parameters.AddWithValue("@troco", obj.Troco);
                // cmd.Parameters.AddWithValue("@fk_id_cliente", obj.Fk_id_cliente);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Venda cadastrada com sucesso!!", "Venda cadastrada!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                //vcon.Dispose();

                //vcon.ClearAllPoolsAsync();

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
                SQLiteCommand cmd = new SQLiteCommand(sql, vcon);
                vcon.Open();
               // cmd.ExecuteNonQuery();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    row = reader.GetInt32(0);
                    
                }
                
                vcon.Close();
                //vcon.Dispose();
               // vcon.ClearAllPoolsAsync();
                return row;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar Codigo da venda: " + ex);
                return 0;
            }       
            
        }
        public DataTable ConsultaVendas()
        {


            try
            {
                DataTable dt = new DataTable();
                /*string sql = @"select 

                                tb_venda.id_venda,                               
	                            tb_cliente.nome,
                                tb_venda.total,
                                tb_venda.pagamento,
                                tb_venda.data
                             from tb_venda
                             inner join tb_cliente on tb_venda.fk_id_cliente = tb_cliente.id_cliente";*/
                string sql = @"select 
                               tb_venda.id_venda as Código,                               
                               tb_cliente.nome as Cliente,
                               tb_venda.total as Total,
                               tb_venda.pagamento as Pagamento,
                               tb_venda.data as Data
                            from tb_venda
                            INNER JOIN tb_cliente ON tb_venda.fk_id_cliente = tb_cliente.id_cliente
                            ORDER BY data desc;";
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

                MessageBox.Show("Erro ao listar Produto: " + ex);
                return null;
            }

        }


    }
}
