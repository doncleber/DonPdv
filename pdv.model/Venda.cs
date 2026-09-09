using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonPdv.pdv.model
{
    class Venda
    {
        //prop + 2 tab
        public int Id_venda { get; set; }
        public int Codigo { get; set; }
        public decimal Valor { get; set; }
       // public int Qtd { get; set; }
        public decimal Total { get; set; }
        public string Pagamento { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Troco { get; set; }
        public DateTime Data { get; set; }

        //public int Fk_id_cliente { get; set; }


    }
}
