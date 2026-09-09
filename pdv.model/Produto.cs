using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonPdv.pdv.model
{
   public class Produto
    {
        //Prop dois tsb
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal ValorCompra { get; set; }
        public int FornecedorId { get; set; }
        public int CategoriaId { get; set; }
        public DateTime Data { get; set; }
    }
}
