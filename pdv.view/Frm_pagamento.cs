using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv.pdv.view
{
    public partial class Frm_pagamento : Form
    {
        decimal total, valorRecebido, troco;
        string p;
        Frm_venda fm;

       

        private void Frm_pagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            valorRecebido = Convert.ToDecimal(tb_valorRecebido.Text);
            if(valorRecebido != 0)
            troco = valorRecebido - total;
            tb_troco.Text = troco.ToString();
               
        }

        private void Frm_pagamento_Load(object sender, EventArgs e)
        {
            cb_pagamento.SelectedIndex = 1;

        }
        private void cb_pagamento_Click(object sender, EventArgs e)
        {
            

        }

        private void cb_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pagamento.SelectedIndex == 0)
            {
                tb_valorRecebido.Enabled = true;
            }
        }

        public Frm_pagamento(decimal total, Frm_venda f)
        {
            InitializeComponent();
            tb_aReceber.Text = total.ToString();
            
            this.total = total;
            fm = f;
            //p = cb_pagamento.Text;
            //troco = Convert.ToDecimal( tb_troco.Text);
            //tb_valorRecebido.Text = "0";
           
            
        }


      private void btn_concluir_Click(object sender, EventArgs e)
        {
            //valorRecebido = Convert.ToDecimal( tb_valorRecebido.Text);
            //troco = Convert.ToDecimal( tb_troco.Text);
            p = cb_pagamento.Text;
            fm.ConcluirVenda(p, valorRecebido, troco);
            Dispose();
            Close();
        }

      
    }
}
