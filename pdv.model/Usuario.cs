using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonPdv.pdv.model
{
   public class Usuario
    {
        public int Id_user { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
        public int Nivel { get; set; }
    }
}
