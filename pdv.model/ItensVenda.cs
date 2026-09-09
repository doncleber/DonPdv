using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonPdv.pdv.model
{
    class  ItensVenda
    {
        public string ProdNome { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public int Qtd { get; set; }
        public decimal Valor { get; set; }
        public decimal Subtotal { get; set; }


        public ItensVenda(int _IdVenda, int _IdProduto, int _Qtd, decimal _Valor, decimal _Subtotal, string _ProdNome)
        {
            ProdNome = _ProdNome;
            IdVenda = _IdVenda;
            IdProduto = _IdProduto;
            Qtd = _Qtd;
            Valor = _Valor;
            Subtotal = _Subtotal;
        }
    }
}
