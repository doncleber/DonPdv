using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonPdv.pdv.model
{
    class Carrinho
    {
        public string Produto { get; set; }
        public int Qtd { get; set; }
        public decimal Valor { get; set; }
        public decimal Subtotal { get; set; }
        //public int IdVenda { get; set; }
        //public DateTime Data { get; set;}


        public Carrinho(string _Produto, int _Qtd, decimal _Valor, decimal _Subtotal) //, int _IdVenda) //DateTime _Data)
        {
            Produto = _Produto;
            //IdVenda = _IdVenda;            
            Qtd = _Qtd;
            Valor = _Valor;
            Subtotal = _Subtotal;
            //Data = _Data;
        }
    }
}
